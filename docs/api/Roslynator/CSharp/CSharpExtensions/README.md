# CSharpExtensions Class

**Namespace**: [Roslynator.CSharp](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Summary

A set of extension methods for a [SemanticModel](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel)\.

```csharp
public static class CSharpExtensions
```

## Methods

| Method | Summary |
| ------ | ------- |
| [DetermineParameter(SemanticModel, ArgumentSyntax, Boolean, Boolean, CancellationToken)](DetermineParameter/README.md) | Determines a parameter symbol that matches to the specified argument\. Returns null if no matching parameter is found\. |
| [DetermineParameter(SemanticModel, AttributeArgumentSyntax, Boolean, Boolean, CancellationToken)](DetermineParameter/README.md) | Determines a parameter symbol that matches to the specified attribute argument\. Returns null if not matching parameter is found\. |
| [GetExtensionMethodInfo(SemanticModel, ExpressionSyntax, CancellationToken)](GetExtensionMethodInfo/README.md) | Returns what extension method symbol, if any, the specified expression syntax bound to\. |
| [GetMethodSymbol(SemanticModel, ExpressionSyntax, CancellationToken)](GetMethodSymbol/README.md) | Returns method symbol, if any, the specified expression syntax bound to\. |
| [GetReducedExtensionMethodInfo(SemanticModel, ExpressionSyntax, CancellationToken)](GetReducedExtensionMethodInfo/README.md) | Returns what extension method symbol, if any, the specified expression syntax bound to\. |
| [GetSymbol(SemanticModel, AttributeSyntax, CancellationToken)](GetSymbol/README.md) | Returns what symbol, if any, the specified attribute syntax bound to\. |
| [GetSymbol(SemanticModel, ConstructorInitializerSyntax, CancellationToken)](GetSymbol/README.md) | Returns what symbol, if any, the specified constructor initializer syntax bound to\. |
| [GetSymbol(SemanticModel, CrefSyntax, CancellationToken)](GetSymbol/README.md) | Returns what symbol, if any, the specified cref syntax bound to\. |
| [GetSymbol(SemanticModel, ExpressionSyntax, CancellationToken)](GetSymbol/README.md) | Returns what symbol, if any, the specified expression syntax bound to\. |
| [GetSymbol(SemanticModel, OrderingSyntax, CancellationToken)](GetSymbol/README.md) | Returns what symbol, if any, the specified ordering syntax bound to\. |
| [GetSymbol(SemanticModel, SelectOrGroupClauseSyntax, CancellationToken)](GetSymbol/README.md) | Returns what symbol, if any, the specified select or group clause bound to\. |
| [GetTypeSymbol(SemanticModel, AttributeSyntax, CancellationToken)](GetTypeSymbol/README.md) | Returns type information about an attribute syntax\. |
| [GetTypeSymbol(SemanticModel, ConstructorInitializerSyntax, CancellationToken)](GetTypeSymbol/README.md) | Returns type information about a constructor initializer syntax\. |
| [GetTypeSymbol(SemanticModel, ExpressionSyntax, CancellationToken)](GetTypeSymbol/README.md) | Returns type information about an expression syntax\. |
| [GetTypeSymbol(SemanticModel, SelectOrGroupClauseSyntax, CancellationToken)](GetTypeSymbol/README.md) | Returns type information about a select or group clause\. |
| [HasConstantValue(SemanticModel, ExpressionSyntax, CancellationToken)](HasConstantValue/README.md) | Returns true if the specified node has a constant value\. |
| [IsDefaultValue(SemanticModel, ITypeSymbol, ExpressionSyntax, CancellationToken)](IsDefaultValue/README.md) | Returns true if the specified expression represents default value of the specified type\. |

