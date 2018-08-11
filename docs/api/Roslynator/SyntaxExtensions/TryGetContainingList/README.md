# SyntaxExtensions\.TryGetContainingList\(SyntaxTrivia, SyntaxTriviaList, Boolean, Boolean\) Method

**Containing Type**: [Roslynator](../../README.md)\.[SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

Gets a [SyntaxTriviaList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivialist) the specified trivia is contained in\.

```csharp
public static bool TryGetContainingList(this SyntaxTrivia trivia, out SyntaxTriviaList triviaList, bool allowLeading = true, bool allowTrailing = true)
```

### Parameters

| Name | Summary |
| ---- | ------- |
| trivia | |
| triviaList | |
| allowLeading | If true, trivia can be part of leading trivia\. |
| allowTrailing | If true, trivia can be part of trailing trivia\. |

### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

