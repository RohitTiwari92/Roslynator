﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Composition;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslynator.CSharp.Comparers;
using Roslynator.CSharp.Refactorings;

namespace Roslynator.CSharp.CodeFixes
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(SynchronizeAccessibilityCodeFixProvider))]
    [Shared]
    public class SynchronizeAccessibilityCodeFixProvider : BaseCodeFixProvider
    {
        public sealed override ImmutableArray<string> FixableDiagnosticIds
        {
            get { return ImmutableArray.Create(CompilerDiagnosticIdentifiers.PartialDeclarationsHaveConfictingAccessibilityModifiers); }
        }

        public override FixAllProvider GetFixAllProvider()
        {
            return null;
        }

        public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            if (!Settings.IsCodeFixEnabled(CodeFixIdentifiers.SynchronizeAccessibility))
                return;

            SyntaxNode root = await context.GetSyntaxRootAsync().ConfigureAwait(false);

            MemberDeclarationSyntax memberDeclaration = root
                .FindNode(context.Span, getInnermostNodeForTie: true)?
                .FirstAncestorOrSelf<MemberDeclarationSyntax>();

            Debug.Assert(memberDeclaration != null, $"{nameof(memberDeclaration)} is null");

            if (memberDeclaration == null)
                return;

            SemanticModel semanticModel = await context.GetSemanticModelAsync().ConfigureAwait(false);

            var symbol = (INamedTypeSymbol)semanticModel.GetDeclaredSymbol(memberDeclaration, context.CancellationToken);

            ImmutableArray<MemberDeclarationSyntax> memberDeclarations = ImmutableArray.CreateRange(
                symbol.DeclaringSyntaxReferences,
                f => (MemberDeclarationSyntax)f.GetSyntax(context.CancellationToken));

            foreach (Accessibility accessibility in memberDeclarations
                .Select(f => f.GetModifiers().GetAccessibility())
                .Where(f => f != Accessibility.NotApplicable))
            {
                if (AccessibilityHelper.IsAllowedAccessibility(memberDeclaration, accessibility))
                {
                    CodeAction codeAction = CodeAction.Create(
                        $"Change accessibility to '{AccessibilityHelper.GetAccessibilityName(accessibility)}'",
                        cancellationToken => ChangeAccessibilityRefactoring.RefactorAsync(context.Solution(), memberDeclarations, accessibility, cancellationToken),
                        $"{CodeFixIdentifiers.SynchronizeAccessibility}_{accessibility}_{EquivalenceKeySuffix}");

                    context.RegisterCodeFix(codeAction, context.Diagnostics);
                }
            }
        }
    }
}
