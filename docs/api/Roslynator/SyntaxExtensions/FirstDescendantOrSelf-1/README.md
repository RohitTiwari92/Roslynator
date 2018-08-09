# SyntaxExtensions\.FirstDescendantOrSelf Method

**Namespace**: [Roslynator](../../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| FirstDescendantOrSelf\<TNode>\(SyntaxNode, Func\<SyntaxNode, Boolean>, Boolean\) | Searches a list of descendant nodes \(including this node\) in prefix document order and returns first descendant of type **TNode**\. |
| FirstDescendantOrSelf\<TNode>\(SyntaxNode, TextSpan, Func\<SyntaxNode, Boolean>, Boolean\) | Searches a list of descendant nodes \(including this node\) in prefix document order and returns first descendant of type **TNode**\. |

## FirstDescendantOrSelf\<TNode>\(SyntaxNode, Func\<SyntaxNode, Boolean>, Boolean\)<a name="Roslynator_SyntaxExtensions_FirstDescendantOrSelf__1_Microsoft_CodeAnalysis_SyntaxNode_System_Func_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean__System_Boolean_"></a>

### Summary

Searches a list of descendant nodes \(including this node\) in prefix document order and returns first descendant of type **TNode**\.

```csharp
public static TNode FirstDescendantOrSelf<TNode>(this SyntaxNode node, Func<SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

#### Type Parameters

| Name | Summary |
| ---- | ------- |
| TNode | |

#### Parameters

| Name | Summary |
| ---- | ------- |
| node | |
| descendIntoChildren | |
| descendIntoTrivia | |

#### Returns

TNode

## FirstDescendantOrSelf\<TNode>\(SyntaxNode, TextSpan, Func\<SyntaxNode, Boolean>, Boolean\)<a name="Roslynator_SyntaxExtensions_FirstDescendantOrSelf__1_Microsoft_CodeAnalysis_SyntaxNode_System_Func_Microsoft_CodeAnalysis_SyntaxNode_System_Boolean__System_Boolean_"></a>

### Summary

Searches a list of descendant nodes \(including this node\) in prefix document order and returns first descendant of type **TNode**\.

```csharp
public static TNode FirstDescendantOrSelf<TNode>(this SyntaxNode node, TextSpan span, Func<SyntaxNode, bool> descendIntoChildren = null, bool descendIntoTrivia = false) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

#### Type Parameters

| Name | Summary |
| ---- | ------- |
| TNode | |

#### Parameters

| Name | Summary |
| ---- | ------- |
| node | |
| span | |
| descendIntoChildren | |
| descendIntoTrivia | |

#### Returns

TNode

