# SimpleAssignmentStatementInfo Struct

Namespace: [Roslynator.CSharp.Syntax](../README.md)

Assembly: Roslynator\.CSharp\.dll

## Summary

Provides information about a simple assignment expression in an expression statement\.

```csharp
readonly struct SimpleAssignmentStatementInfo
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; SimpleAssignmentStatementInfo

### Implements

* [IEquatable](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)\<[SimpleAssignmentStatementInfo](./README.md)>

## Properties

| Property | Summary |
| -------- | ------- |
| [AssignmentExpression](AssignmentExpression/README.md) | The simple assignment expression\. |
| [Left](Left/README.md) | The expression on the left of the assignment operator\. |
| [OperatorToken](OperatorToken/README.md) | The operator of the simple assignment expression\. |
| [Right](Right/README.md) | The expression of the right of the assignment operator\. |
| [Statement](Statement/README.md) | The expression statement the simple assignment expression is contained in\. |
| [Success](Success/README.md) | Determines whether this struct was initialized with an actual syntax\. |

## Methods

| Method | Summary |
| ------ | ------- |
| [Equals(Object)](Equals/README.md) | Determines whether this instance and a specified object are equal\. |
| [Equals(SimpleAssignmentStatementInfo)](Equals/README.md) | Determines whether this instance is equal to another object of the same type\. |
| [GetHashCode()](GetHashCode/README.md) | Returns the hash code for this instance\. |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](ToString/README.md) | Returns the string representation of the underlying syntax, not including its leading and trailing trivia\. |

## Operators

| Operator | Summary |
| -------- | ------- |
| [Equality(SimpleAssignmentStatementInfo, SimpleAssignmentStatementInfo)](op_Equality/README.md) | |
| [Inequality(SimpleAssignmentStatementInfo, SimpleAssignmentStatementInfo)](op_Inequality/README.md) | |

