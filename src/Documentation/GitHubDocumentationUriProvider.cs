﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    public class GitHubDocumentationUriProvider : DocumentationUriProvider
    {
        public const string ReadMeFileName = "README.md";

        public GitHubDocumentationUriProvider(IEnumerable<ExternalUriProvider> externalProviders = null)
            : base(externalProviders)
        {
        }

        public override string GetFilePath(DocumentationKind kind, SymbolDocumentationModel symbolModel)
        {
            switch (kind)
            {
                case DocumentationKind.Root:
                    return ReadMeFileName;
                case DocumentationKind.Namespace:
                case DocumentationKind.Type:
                case DocumentationKind.Member:
                    return GetFullUri(ReadMeFileName, symbolModel.NameAndBaseNamesAndNamespaceNames, Path.DirectorySeparatorChar);
                case DocumentationKind.ObjectModel:
                    return WellKnownNames.ObjectModelFileName;
                case DocumentationKind.ExtendedExternalTypes:
                    return WellKnownNames.ExtendedExternalTypesFileName;
                default:
                    throw new ArgumentException("", nameof(kind));
            }
        }

        public override DocumentationUrlInfo GetLocalUrl(SymbolDocumentationModel symbolModel)
        {
            string url = CreateLocalUrl();

            return new DocumentationUrlInfo(url, DocumentationUrlKind.Local);

            string CreateLocalUrl()
            {
                if (DirectoryModel == null)
                    return GetFullUri(ReadMeFileName, symbolModel.NameAndBaseNamesAndNamespaceNames, '/');

                if (symbolModel == DirectoryModel)
                    return "./" + ReadMeFileName;

                int count = 0;

                ImmutableArray<ISymbol> symbols = symbolModel.SymbolAndBaseTypesAndNamespaces;

                int i = symbols.Length - 1;
                int j = DirectoryModel.SymbolAndBaseTypesAndNamespaces.Length - 1;

                while (i >= 0
                    && j >= 0
                    && symbols[i] == DirectoryModel.SymbolAndBaseTypesAndNamespaces[j])
                {
                    count++;
                    i--;
                    j--;
                }

                int diff = DirectoryModel.SymbolAndBaseTypesAndNamespaces.Length - count;

                StringBuilder sb = StringBuilderCache.GetInstance();

                if (diff > 0)
                {
                    sb.Append("..");
                    diff--;

                    while (diff > 0)
                    {
                        sb.Append("/..");
                        diff--;
                    }
                }

                ImmutableArray<string> names = symbolModel.NameAndBaseNamesAndNamespaceNames;

                i = names.Length - 1 - count;

                if (i >= 0)
                {
                    if (sb.Length > 0)
                        sb.Append("/");

                    sb.Append(names[i]);
                    i--;

                    while (i >= 0)
                    {
                        sb.Append("/");
                        sb.Append(names[i]);
                        i--;
                    }
                }

                sb.Append("/");
                sb.Append(ReadMeFileName);

                return StringBuilderCache.GetStringAndFree(sb);
            }
        }
    }
}
