# CSharpFactory\.AsExpression Method

**Namespace**: [Roslynator.CSharp](../../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| AsExpression\(ExpressionSyntax, ExpressionSyntax\) | |
| AsExpression\(ExpressionSyntax, SyntaxToken, ExpressionSyntax\) | |

## AsExpression\(ExpressionSyntax, ExpressionSyntax\)

```csharp
public static BinaryExpressionSyntax AsExpression(ExpressionSyntax left, ExpressionSyntax right)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| left | |
| right | |

#### Returns

[BinaryExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.binaryexpressionsyntax)

## AsExpression\(ExpressionSyntax, SyntaxToken, ExpressionSyntax\)

```csharp
public static BinaryExpressionSyntax AsExpression(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| left | |
| operatorToken | |
| right | |

#### Returns

[BinaryExpressionSyntax](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax.binaryexpressionsyntax)
