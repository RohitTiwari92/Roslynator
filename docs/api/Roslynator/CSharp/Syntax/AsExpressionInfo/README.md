# AsExpressionInfo Struct

Namespace: [Roslynator.CSharp.Syntax](../README.md)

Assembly: Roslynator\.CSharp\.dll

## Summary

Provides information about "as" expression\.

```csharp
public readonly struct AsExpressionInfo : System.IEquatable<Roslynator.CSharp.Syntax.AsExpressionInfo>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; AsExpressionInfo

### Implements

* [IEquatable](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)\<[AsExpressionInfo](./README.md)>

## Properties

| Property | Summary |
| -------- | ------- |
| [AsExpression](AsExpression/README.md) | The "as" expression\. |
| [Expression](Expression/README.md) | The expression that is being casted\. |
| [OperatorToken](OperatorToken/README.md) | The "as" operator token\. |
| [Success](Success/README.md) | Determines whether this struct was initialized with an actual syntax\. |
| [Type](Type/README.md) | The type to which the expression is being cast\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(AsExpressionInfo)](Equals/README.md) | Determines whether this instance is equal to another object of the same type\. |
| [Equals(Object)](Equals/README.md) | Determines whether this instance and a specified object are equal\. |
| [GetHashCode()](GetHashCode/README.md) | Returns the hash code for this instance\. |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](ToString/README.md) | Returns the string representation of the underlying syntax, not including its leading and trailing trivia\. |

## Operators

| Operator | Summary |
| -------- | ------- |
| [Equality(AsExpressionInfo, AsExpressionInfo)](op_Equality/README.md) | |
| [Inequality(AsExpressionInfo, AsExpressionInfo)](op_Inequality/README.md) | |

