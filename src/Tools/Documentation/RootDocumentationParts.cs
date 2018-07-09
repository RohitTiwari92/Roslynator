﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

#pragma warning disable CA2217, RCS1157

namespace Roslynator.Documentation
{
    [Flags]
    public enum RootDocumentationParts
    {
        None = 0,
        ObjectModelLink = 1,
        ExtendedTypesLink = 2,
        NamespaceList = 4,
        Namespaces = 8,
        All = int.MaxValue
    }
}
