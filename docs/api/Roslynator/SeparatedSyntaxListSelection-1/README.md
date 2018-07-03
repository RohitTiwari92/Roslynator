# SeparatedSyntaxListSelection\<TNode> Class

Namespace: [Roslynator](../README.md)

Assembly: Roslynator\.CSharp\.dll

## Summary

Represents selected nodes in a \.

#### Type Parameters

| Type Parameter| Summary|
| --- | --- |
| TNode | |

#### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [Selection\<T>](../Selection-1/README.md) &#x2192; SeparatedSyntaxListSelection\<TNode>

#### Implements

* [IEnumerable\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)
* [IReadOnlyCollection\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1)
* [IReadOnlyList\<TNode>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)

## Constructors

| Constructor| Summary|
| --- | --- |
| [SeparatedSyntaxListSelection(SeparatedSyntaxList\<TNode>, TextSpan, Int32, Int32)](-ctor/README.md) | Initializes a new instance of the \. |

## Properties

| Property| Summary|
| --- | --- |
| [Items](Items/README.md) | Gets an underlying list that contains selected nodes\. |
| [UnderlyingList](UnderlyingList/README.md) | Gets an underlying list that contains selected nodes\. |

## Methods

| Method| Summary|
| --- | --- |
| [Create(SeparatedSyntaxList\<TNode>, TextSpan)](Create/README.md) | Creates a new  based on the specified list and span\. |
| [GetEnumerator()](GetEnumerator/README.md) | Returns an enumerator that iterates through selected items\. |
| [GetEnumeratorCore()](GetEnumeratorCore/README.md) | |
| [TryCreate(SeparatedSyntaxList\<TNode>, TextSpan, SeparatedSyntaxListSelection\<TNode>)](TryCreate/README.md) | Creates a new  based on the specified list and span\. |
