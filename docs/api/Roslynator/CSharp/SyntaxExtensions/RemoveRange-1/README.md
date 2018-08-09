# SyntaxExtensions\.RemoveRange Method

**Namespace**: [Roslynator.CSharp](../../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| RemoveRange\(SyntaxTokenList, Int32, Int32\) | Creates a new list with tokens in the specified range removed\. |
| RemoveRange\(SyntaxTriviaList, Int32, Int32\) | Creates a new list with trivia in the specified range removed\. |
| RemoveRange\<TNode>\(SeparatedSyntaxList\<TNode>, Int32, Int32\) | Creates a new list with elements in the specified range removed\. |
| RemoveRange\<TNode>\(SyntaxList\<TNode>, Int32, Int32\) | Creates a new list with elements in the specified range removed\. |

## RemoveRange\<TNode>\(SeparatedSyntaxList\<TNode>, Int32, Int32\)<a name="Roslynator_CSharp_SyntaxExtensions_RemoveRange__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__System_Int32_System_Int32_"></a>

### Summary

Creates a new list with elements in the specified range removed\.

```csharp
public static SeparatedSyntaxList<TNode> RemoveRange<TNode>(this SeparatedSyntaxList<TNode> list, int index, int count) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

#### Type Parameters

| Name | Summary |
| ---- | ------- |
| TNode | |

#### Parameters

| Name | Summary |
| ---- | ------- |
| list | |
| index | An index of the first element to remove\. |
| count | A number of elements to remove\. |

#### Returns

[SeparatedSyntaxList\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)

## RemoveRange\<TNode>\(SyntaxList\<TNode>, Int32, Int32\)<a name="Roslynator_CSharp_SyntaxExtensions_RemoveRange__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__System_Int32_System_Int32_"></a>

### Summary

Creates a new list with elements in the specified range removed\.

```csharp
public static SyntaxList<TNode> RemoveRange<TNode>(this SyntaxList<TNode> list, int index, int count) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

#### Type Parameters

| Name | Summary |
| ---- | ------- |
| TNode | |

#### Parameters

| Name | Summary |
| ---- | ------- |
| list | |
| index | An index of the first element to remove\. |
| count | A number of elements to remove\. |

#### Returns

[SyntaxList\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxlist-1)

## RemoveRange\(SyntaxTokenList, Int32, Int32\)<a name="Roslynator_CSharp_SyntaxExtensions_RemoveRange__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__System_Int32_System_Int32_"></a>

### Summary

Creates a new list with tokens in the specified range removed\.

```csharp
public static SyntaxTokenList RemoveRange(this SyntaxTokenList list, int index, int count)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| list | |
| index | An index of the first element to remove\. |
| count | A number of elements to remove\. |

#### Returns

[SyntaxTokenList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtokenlist)

## RemoveRange\(SyntaxTriviaList, Int32, Int32\)<a name="Roslynator_CSharp_SyntaxExtensions_RemoveRange__1_Microsoft_CodeAnalysis_SeparatedSyntaxList___0__System_Int32_System_Int32_"></a>

### Summary

Creates a new list with trivia in the specified range removed\.

```csharp
public static SyntaxTriviaList RemoveRange(this SyntaxTriviaList list, int index, int count)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| list | |
| index | An index of the first element to remove\. |
| count | A number of elements to remove\. |

#### Returns

[SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist)

