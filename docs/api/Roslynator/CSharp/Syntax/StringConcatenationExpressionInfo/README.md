# StringConcatenationExpressionInfo Struct

Namespace: [Roslynator.CSharp.Syntax](../README.md)

Assembly: Roslynator\.CSharp\.dll

## Summary

Provides information about string concatenation, i\.e\. a binary expression that binds to string '\+' operator\.

#### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; StringConcatenationExpressionInfo

#### Implements

* [IEquatable\<StringConcatenationExpressionInfo>](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1)

## Properties

| Property| Summary|
| --- | --- |
| [BinaryExpression](BinaryExpression/README.md) | The binary expression that represents the string concatenation\. |
| [Success](Success/README.md) | Determines whether this struct was initialized with an actual syntax\. |

## Methods

| Method| Summary|
| --- | --- |
| [AsChain()](AsChain/README.md) | |
| [Equals(Object)](Equals/README.md) | Determines whether this instance and a specified object are equal\. |
| [Equals(StringConcatenationExpressionInfo)](Equals/README.md) | Determines whether this instance is equal to another object of the same type\. |
| [Expressions(Boolean)](Expressions/README.md) | Returns expressions of this binary expression, including expressions of nested binary expressions of the same kind as parent binary expression\. |
| [GetHashCode()](GetHashCode/README.md) | Returns the hash code for this instance\. |
| [ToString()](ToString/README.md) | Returns the string representation of the underlying syntax, not including its leading and trailing trivia\. |

## Operators

| Operator| Summary|
| --- | --- |
| [operator !=(StringConcatenationExpressionInfo, StringConcatenationExpressionInfo)](op_Inequality/README.md) | |
| [operator ==(StringConcatenationExpressionInfo, StringConcatenationExpressionInfo)](op_Equality/README.md) | |

