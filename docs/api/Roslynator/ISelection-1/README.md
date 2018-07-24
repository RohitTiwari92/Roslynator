# ISelection\<T> Interface

Namespace: [Roslynator](../README.md)

Assembly: Roslynator\.CSharp\.dll

## Summary

Represents consecutive sequence of selected items in a collection\.

```csharp
public interface ISelection<T> : System.Collections.Generic.IEnumerable<T>,
    System.Collections.Generic.IReadOnlyCollection<T>,
    System.Collections.Generic.IReadOnlyList<T>
```

### Type Parameters

| Name | Summary |
| ---- | ------- |
| T | |

### Derived

* [Roslynator.CSharp.MemberDeclarationListSelection](../CSharp/MemberDeclarationListSelection/README.md)
* [Roslynator.CSharp.StatementListSelection](../CSharp/StatementListSelection/README.md)
* [Roslynator.SeparatedSyntaxListSelection\<TNode>](../SeparatedSyntaxListSelection-1/README.md)
* [Roslynator.SyntaxListSelection\<TNode>](../SyntaxListSelection-1/README.md)
* [Roslynator.Text.TextLineCollectionSelection](../Text/TextLineCollectionSelection/README.md)

### Implements

* [IEnumerable\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)
* [IReadOnlyCollection\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1)
* [IReadOnlyList\<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)

## Properties

| Property | Summary |
| -------- | ------- |
| [FirstIndex](FirstIndex/README.md) | Gets an index of the first selected item\. |
| [LastIndex](LastIndex/README.md) | Gets an index of the last selected item\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [First()](First/README.md) | Gets the first selected item\. |
| [Last()](Last/README.md) | Gets the last selected item\. |

