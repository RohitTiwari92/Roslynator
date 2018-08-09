# SyntaxInfo\.ConditionalExpressionInfo Method

**Namespace**: [Roslynator.CSharp](../../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| ConditionalExpressionInfo\(ConditionalExpressionSyntax, Boolean, Boolean\) | Creates a new [ConditionalExpressionInfo](../../Syntax/ConditionalExpressionInfo/README.md) from the specified conditional expression\. |
| ConditionalExpressionInfo\(SyntaxNode, Boolean, Boolean\) | Creates a new [ConditionalExpressionInfo](../../Syntax/ConditionalExpressionInfo/README.md) from the specified node\. |

## ConditionalExpressionInfo\(SyntaxNode, Boolean, Boolean\)<a name="Roslynator_CSharp_SyntaxInfo_ConditionalExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean_System_Boolean_"></a>

### Summary

Creates a new [ConditionalExpressionInfo](../../Syntax/ConditionalExpressionInfo/README.md) from the specified node\.

```csharp
public static ConditionalExpressionInfo ConditionalExpressionInfo(SyntaxNode node, bool walkDownParentheses = true, bool allowMissing = false)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| node | |
| walkDownParentheses | |
| allowMissing | |

#### Returns

[ConditionalExpressionInfo](../../Syntax/ConditionalExpressionInfo/README.md)

## ConditionalExpressionInfo\(ConditionalExpressionSyntax, Boolean, Boolean\)<a name="Roslynator_CSharp_SyntaxInfo_ConditionalExpressionInfo_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean_System_Boolean_"></a>

### Summary

Creates a new [ConditionalExpressionInfo](../../Syntax/ConditionalExpressionInfo/README.md) from the specified conditional expression\.

```csharp
public static ConditionalExpressionInfo ConditionalExpressionInfo(ConditionalExpressionSyntax conditionalExpression, bool walkDownParentheses = true, bool allowMissing = false)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| conditionalExpression | |
| walkDownParentheses | |
| allowMissing | |

#### Returns

[ConditionalExpressionInfo](../../Syntax/ConditionalExpressionInfo/README.md)

