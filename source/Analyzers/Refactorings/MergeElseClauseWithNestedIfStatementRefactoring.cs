﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Roslynator.CSharp.Refactorings
{
    internal static class MergeElseClauseWithNestedIfStatementRefactoring
    {
        public static void AnalyzeElseClause(SyntaxNodeAnalysisContext context)
        {
            var elseClause = (ElseClauseSyntax)context.Node;

            if (!(elseClause.Statement is BlockSyntax block))
                return;

            if (!(block.Statements.SingleOrDefault(shouldThrow: false) is IfStatementSyntax ifStatement))
                return;

            if (!elseClause.ElseKeyword.TrailingTrivia.IsEmptyOrWhitespace()
                || !block.OpenBraceToken.LeadingTrivia.IsEmptyOrWhitespace()
                || !block.OpenBraceToken.TrailingTrivia.IsEmptyOrWhitespace()
                || !ifStatement.IfKeyword.LeadingTrivia.IsEmptyOrWhitespace()
                || !ifStatement.GetTrailingTrivia().IsEmptyOrWhitespace()
                || !block.CloseBraceToken.LeadingTrivia.IsEmptyOrWhitespace())
            {
                return;
            }

            context.ReportDiagnostic(DiagnosticDescriptors.MergeElseClauseWithNestedIfStatement, block);
            context.ReportBraces(DiagnosticDescriptors.MergeElseClauseWithNestedIfStatementFadeOut, block);
        }
    }
}
