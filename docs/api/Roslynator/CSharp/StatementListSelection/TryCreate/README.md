# StatementListSelection\.TryCreate Method

**Namespace**: [Roslynator.CSharp](../../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [TryCreate(BlockSyntax, TextSpan, StatementListSelection)](#Roslynator_CSharp_StatementListSelection_TryCreate_Microsoft_CodeAnalysis_CSharp_Syntax_BlockSyntax_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_StatementListSelection__) | Creates a new [StatementListSelection](../README.md) based on the specified block and span\. |
| [TryCreate(SwitchSectionSyntax, TextSpan, StatementListSelection)](#Roslynator_CSharp_StatementListSelection_TryCreate_Microsoft_CodeAnalysis_CSharp_Syntax_SwitchSectionSyntax_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_StatementListSelection__) | Creates a new [StatementListSelection](../README.md) based on the specified switch section and span\. |

## TryCreate\(BlockSyntax, TextSpan, StatementListSelection\)<a name="Roslynator_CSharp_StatementListSelection_TryCreate_Microsoft_CodeAnalysis_CSharp_Syntax_BlockSyntax_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_StatementListSelection__"></a>

### Summary

Creates a new [StatementListSelection](../README.md) based on the specified block and span\.

```csharp
public static bool TryCreate(BlockSyntax block, TextSpan span, out StatementListSelection selectedStatements)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| block | |
| span | |
| selectedStatements | |

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

True if the specified span contains at least one statement; otherwise, false\.

## TryCreate\(SwitchSectionSyntax, TextSpan, StatementListSelection\)<a name="Roslynator_CSharp_StatementListSelection_TryCreate_Microsoft_CodeAnalysis_CSharp_Syntax_SwitchSectionSyntax_Microsoft_CodeAnalysis_Text_TextSpan_Roslynator_CSharp_StatementListSelection__"></a>

### Summary

Creates a new [StatementListSelection](../README.md) based on the specified switch section and span\.

```csharp
public static bool TryCreate(SwitchSectionSyntax switchSection, TextSpan span, out StatementListSelection selectedStatements)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| switchSection | |
| span | |
| selectedStatements | |

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

True if the specified span contains at least one statement; otherwise, false\.