﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.CodeAnalysis;

namespace Roslynator.Documentation
{
    public abstract class SymbolDisplayFormatProvider
    {
        public static SymbolDisplayFormatProvider Default { get; } = new DefaultSymbolDisplayFormatProvider();

        public abstract SymbolDisplayFormat TitleFormat { get; }

        public abstract SymbolDisplayFormat MemberTitleFormat { get; }

        public abstract SymbolDisplayFormat OverloadedMemberTitleFormat { get; }

        public abstract SymbolDisplayFormat NamespaceFormat { get; }

        public abstract SymbolDisplayFormat TypeFormat { get; }

        public abstract SymbolDisplayFormat DefinitionFormat { get; }

        public abstract SymbolDisplayFormat TypeParameterFormat { get; }

        public abstract SymbolDisplayFormat ParameterFormat { get; }

        public abstract SymbolDisplayFormat InheritanceFormat { get; }

        public abstract SymbolDisplayFormat DerivedFormat { get; }

        public abstract SymbolDisplayFormat MemberImplementsFormat { get; }

        public abstract SymbolDisplayFormat AttributeFormat { get; }

        public abstract SymbolDisplayFormat ConstructorFormat { get; }

        public abstract SymbolDisplayFormat FieldFormat { get; }

        public abstract SymbolDisplayFormat PropertyFormat { get; }

        public abstract SymbolDisplayFormat MethodFormat { get; }

        public abstract SymbolDisplayFormat EventFormat { get; }

        public abstract SymbolDisplayFormat CrefFormat { get; }

        private class DefaultSymbolDisplayFormatProvider : SymbolDisplayFormatProvider
        {
            public override SymbolDisplayFormat TitleFormat
            {
                get { return SymbolDisplayFormats.TypeNameAndContainingTypesAndTypeParameters; }
            }

            public override SymbolDisplayFormat MemberTitleFormat
            {
                get { return SymbolDisplayFormats.MemberTitle; }
            }

            public override SymbolDisplayFormat OverloadedMemberTitleFormat
            {
                get { return SymbolDisplayFormats.OverloadedMemberTitle; }
            }

            public override SymbolDisplayFormat NamespaceFormat
            {
                get { return SymbolDisplayFormats.TypeNameAndContainingTypesAndNamespacesAndTypeParameters; }
            }

            public override SymbolDisplayFormat TypeFormat
            {
                get { return SymbolDisplayFormats.TypeNameAndContainingTypesAndTypeParameters; }
            }

            public override SymbolDisplayFormat DefinitionFormat
            {
                get { return SymbolDisplayFormats.FullDefinition; }
            }

            public override SymbolDisplayFormat TypeParameterFormat
            {
                get { return SymbolDisplayFormats.Default; }
            }

            public override SymbolDisplayFormat ParameterFormat
            {
                get { return SymbolDisplayFormats.Default; }
            }

            public override SymbolDisplayFormat InheritanceFormat
            {
                get { return SymbolDisplayFormats.TypeNameAndContainingTypesAndTypeParameters; }
            }

            public override SymbolDisplayFormat DerivedFormat
            {
                get { return SymbolDisplayFormats.TypeNameAndContainingTypesAndNamespacesAndTypeParameters; }
            }

            public override SymbolDisplayFormat MemberImplementsFormat
            {
                get { return SymbolDisplayFormats.MemberImplements; }
            }

            public override SymbolDisplayFormat AttributeFormat
            {
                get { return SymbolDisplayFormats.TypeNameAndContainingTypesAndTypeParameters; }
            }

            public override SymbolDisplayFormat ConstructorFormat
            {
                get { return SymbolDisplayFormats.SimpleDefinition; }
            }

            public override SymbolDisplayFormat FieldFormat
            {
                get { return SymbolDisplayFormats.SimpleDefinition; }
            }

            public override SymbolDisplayFormat PropertyFormat
            {
                get { return SymbolDisplayFormats.SimpleDefinition; }
            }

            public override SymbolDisplayFormat MethodFormat
            {
                get { return SymbolDisplayFormats.SimpleDefinition; }
            }

            public override SymbolDisplayFormat EventFormat
            {
                get { return SymbolDisplayFormats.SimpleDefinition; }
            }

            public override SymbolDisplayFormat CrefFormat
            {
                get { return SymbolDisplayFormats.TypeNameAndContainingTypesAndTypeParameters; }
            }
        }
    }
}
