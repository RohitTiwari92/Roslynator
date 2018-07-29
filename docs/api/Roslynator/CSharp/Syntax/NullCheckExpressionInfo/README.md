# NullCheckExpressionInfo Struct

Namespace: [Roslynator.CSharp.Syntax](../README.md)

Assembly: Roslynator\.CSharp\.dll

## Summary

Provides information about a null check expression\.

```csharp
public readonly struct NullCheckExpressionInfo : System.IEquatable<NullCheckExpressionInfo>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; NullCheckExpressionInfo

### Implements

* [IEquatable](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)\<[NullCheckExpressionInfo](./README.md)>

## Properties

| Property | Summary |
| -------- | ------- |
| [Expression](Expression/README.md) | The expression that is evaluated whether is \(not\) null\. for example "x" in "x == null"\. |
| [IsCheckingNotNull](IsCheckingNotNull/README.md) | Determines whether this null check is checking if the expression is not null\. |
| [IsCheckingNull](IsCheckingNull/README.md) | Determines whether this null check is checking if the expression is null\. |
| [NullCheckExpression](NullCheckExpression/README.md) | The null check expression, e\.g\. "x == null"\. |
| [Style](Style/README.md) | The style of this null check\. |
| [Success](Success/README.md) | Determines whether this struct was initialized with an actual syntax\. |

## Methods

| Method | Summary |
| ------ | ------- |
| **[Equals(NullCheckExpressionInfo)](Equals/README.md)** | Determines whether this instance is equal to another object of the same type\. |
| **[Equals(Object)](Equals/README.md)** | Determines whether this instance and a specified object are equal\. |
| **[GetHashCode()](GetHashCode/README.md)** | Returns the hash code for this instance\. |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| **[ToString()](ToString/README.md)** | Returns the string representation of the underlying syntax, not including its leading and trailing trivia\. |

## Operators

| Operator | Summary |
| -------- | ------- |
| [Equality(NullCheckExpressionInfo, NullCheckExpressionInfo)](op_Equality/README.md) | |
| [Inequality(NullCheckExpressionInfo, NullCheckExpressionInfo)](op_Inequality/README.md) | |

