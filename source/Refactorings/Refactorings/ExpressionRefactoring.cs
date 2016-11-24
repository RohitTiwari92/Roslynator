﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Roslynator.CSharp.Refactorings
{
    internal static class ExpressionRefactoring
    {
        public static async Task ComputeRefactoringsAsync(RefactoringContext context, ExpressionSyntax expression)
        {
            if (context.IsRefactoringEnabled(RefactoringIdentifiers.ExtractExpressionFromCondition))
            {
                ExtractExpressionFromIfConditionRefactoring.ComputeRefactoring(context, expression);
                ExtractExpressionFromWhileConditionRefactoring.ComputeRefactoring(context, expression);
            }

            if (context.IsRefactoringEnabled(RefactoringIdentifiers.ParenthesizeExpression)
                && context.Span.IsBetweenSpans(expression)
                && ParenthesizeExpressionRefactoring.CanRefactor(context, expression))
            {
                context.RegisterRefactoring(
                    $"Parenthesize '{expression.ToString()}'",
                    cancellationToken => ParenthesizeExpressionRefactoring.RefactorAsync(context.Document, expression, cancellationToken));
            }

            if (context.IsRefactoringEnabled(RefactoringIdentifiers.ReplaceNullLiteralExpressionWithDefaultExpression))
                await ReplaceNullLiteralExpressionWithDefaultExpressionRefactoring.ComputeRefactoringAsync(context, expression).ConfigureAwait(false);

            if (context.Settings.IsRefactoringEnabled(RefactoringIdentifiers.ReplaceConditionalExpressionWithExpression))
                ReplaceConditionalExpressionWithExpressionRefactoring.ComputeRefactoring(context, expression);
        }
    }
}
