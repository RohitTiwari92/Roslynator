# SyntaxInfo\.SingleLocalDeclarationStatementInfo Method

**Namespace**: [Roslynator.CSharp](../../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [SingleLocalDeclarationStatementInfo(ExpressionSyntax)](#Roslynator_CSharp_SyntaxInfo_SingleLocalDeclarationStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_) | Creates a new [SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md) from the specified value\. |
| [SingleLocalDeclarationStatementInfo(LocalDeclarationStatementSyntax, Boolean)](#Roslynator_CSharp_SyntaxInfo_SingleLocalDeclarationStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LocalDeclarationStatementSyntax_System_Boolean_) | Creates a new [SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md) from the specified local declaration statement\. |
| [SingleLocalDeclarationStatementInfo(VariableDeclarationSyntax, Boolean)](#Roslynator_CSharp_SyntaxInfo_SingleLocalDeclarationStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_VariableDeclarationSyntax_System_Boolean_) | Creates a new [SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md) from the specified variable declaration\. |

## SingleLocalDeclarationStatementInfo\(ExpressionSyntax\)<a name="Roslynator_CSharp_SyntaxInfo_SingleLocalDeclarationStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LocalDeclarationStatementSyntax_System_Boolean_"></a>

### Summary

Creates a new [SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md) from the specified value\.

```csharp
public static SingleLocalDeclarationStatementInfo SingleLocalDeclarationStatementInfo(ExpressionSyntax value)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| value | |

#### Returns

[SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md)

## SingleLocalDeclarationStatementInfo\(LocalDeclarationStatementSyntax, Boolean\)<a name="Roslynator_CSharp_SyntaxInfo_SingleLocalDeclarationStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LocalDeclarationStatementSyntax_System_Boolean_"></a>

### Summary

Creates a new [SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md) from the specified local declaration statement\.

```csharp
public static SingleLocalDeclarationStatementInfo SingleLocalDeclarationStatementInfo(LocalDeclarationStatementSyntax localDeclarationStatement, bool allowMissing = false)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| localDeclarationStatement | |
| allowMissing | |

#### Returns

[SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md)

## SingleLocalDeclarationStatementInfo\(VariableDeclarationSyntax, Boolean\)<a name="Roslynator_CSharp_SyntaxInfo_SingleLocalDeclarationStatementInfo_Microsoft_CodeAnalysis_CSharp_Syntax_LocalDeclarationStatementSyntax_System_Boolean_"></a>

### Summary

Creates a new [SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md) from the specified variable declaration\.

```csharp
public static SingleLocalDeclarationStatementInfo SingleLocalDeclarationStatementInfo(VariableDeclarationSyntax variableDeclaration, bool allowMissing = false)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| variableDeclaration | |
| allowMissing | |

#### Returns

[SingleLocalDeclarationStatementInfo](../../Syntax/SingleLocalDeclarationStatementInfo/README.md)

