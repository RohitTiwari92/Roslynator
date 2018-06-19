﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Roslynator.Tests;
using Xunit;

#pragma warning disable RCS1090

namespace Roslynator.CSharp.Refactorings.Tests
{
    public class RR0184SplitIfStatementTests : AbstractCSharpCodeRefactoringVerifier
    {
        public override string RefactoringId { get; } = RefactoringIdentifiers.SplitIfStatement;

        [Fact, Trait(Traits.Refactoring, RefactoringIdentifiers.SplitIfStatement)]
        public async Task Test_LogicalOr()
        {
            await VerifyRefactoringAsync(@"
class C
{
    bool M(bool x, bool y)
    {
        [||]if (x || y)
        {
            return true;
        }

        return false;
    }
}
", @"
class C
{
    bool M(bool x, bool y)
    {
        if (x)
        {
            return true;
        }

        if (y)
        {
            return true;
        }

        return false;
    }
}
", equivalenceKey: RefactoringId);
        }

        [Fact, Trait(Traits.Refactoring, RefactoringIdentifiers.SplitIfStatement)]
        public async Task Test_LogicalOr2()
        {
            await VerifyRefactoringAsync(@"
class C
{
    bool M(bool a, bool b, bool c, bool d, bool e)
    {
        // a
        [||]if (a || b || c || d && e)
        {
            return true;
        } // b

        return false;
    }
}
", @"
class C
{
    bool M(bool a, bool b, bool c, bool d, bool e)
    {
        // a
        if (a)
        {
            return true;
        }

        if (b)
        {
            return true;
        }

        if (c)
        {
            return true;
        }

        if (d && e)
        {
            return true;
        } // b

        return false;
    }
}
", equivalenceKey: RefactoringId);
        }

        [Fact, Trait(Traits.Refactoring, RefactoringIdentifiers.SplitIfStatement)]
        public async Task Test_LogicalOr_EmbeddedStatement()
        {
            await VerifyRefactoringAsync(@"
class C
{
    bool M(bool a, bool b, bool c, bool d)
    {
        if (a)
            [||]if (b || c && d)
            {
                return true;
            }

        return false;
    }
}
", @"
class C
{
    bool M(bool a, bool b, bool c, bool d)
    {
        if (a)
        {
            if (b)
            {
                return true;
            }

            if (c && d)
            {
                return true;
            }
        }

        return false;
    }
}
", equivalenceKey: RefactoringId);
        }

        [Fact, Trait(Traits.Refactoring, RefactoringIdentifiers.SplitIfStatement)]
        public async Task TestNoRefactoring_SimpleCondition()
        {
            await VerifyNoRefactoringAsync(@"
class C
{
    bool M(bool f)
    {
        [||]if (f)
        {
            return true;
        }

        return false;
    }
}
", equivalenceKey: RefactoringId);
        }
    }
}
