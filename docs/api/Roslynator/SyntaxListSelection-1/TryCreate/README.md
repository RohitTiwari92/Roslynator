# SyntaxListSelection\<TNode>\.TryCreate\(SyntaxList\<TNode>, TextSpan, SyntaxListSelection\<TNode>\) Method

[Home](../../../README.md)

**Containing Type**: [Roslynator](../../README.md)\.[SyntaxListSelection\<TNode>](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Creates a new [SyntaxListSelection\<TNode>](../README.md) based on the specified list and span\.

```csharp
public static bool TryCreate(SyntaxList<TNode> list, TextSpan span, out SyntaxListSelection<TNode> selection)
```

### Parameters

| Name | Summary |
| ---- | ------- |
| list | |
| span | |
| selection | |

### Returns

System\.[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

True if the specified span contains at least one node; otherwise, false\.