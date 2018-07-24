﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

#pragma warning disable CS0618, CS1591, RCS1079 

namespace Roslynator.Documentation.Test
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
    public sealed class MyAttribute : Attribute
    {
        [My(
            default(object),
            @"\n",
            true,
            false,
            0,
            '\'',
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            typeof(object),
            Flags.None,
            Flags.None | Flags.A,
            Flags.A,
            Flags.B | Flags.C | Flags.A,
            Flags.AB,
            (Flags)100)]
        public MyAttribute(
            object object1,
            string s1,
            bool bool1,
            bool bool2,
            byte byte1,
            char ch1,
            double double1,
            float float1,
            int int1,
            long long1,
            sbyte sbyte1,
            short short1,
            uint uint1,
            ulong ulong1,
            ushort ushort1,
            Type type,
            Flags f1,
            Flags f2,
            Flags f3,
            Flags f4,
            Flags f5,
            Flags f6
            )
        {
        }
    }
}
