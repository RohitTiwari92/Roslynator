# NullCheckExpressionInfo\.Equals Method

**Namespace**: [Roslynator.CSharp.Syntax](../../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| Equals\(NullCheckExpressionInfo\) | Determines whether this instance is equal to another object of the same type\. \(Implements [IEquatable\<NullCheckExpressionInfo>.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1.equals)\) |
| Equals\(Object\) | Determines whether this instance and a specified object are equal\. \(Overrides [ValueType.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.equals)\) |

## Equals\(Object\)

### Summary

Determines whether this instance and a specified object are equal\.

```csharp
public override bool Equals(object obj)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| obj | The object to compare with the current instance\.  |

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

true if **obj** and this instance are the same type and represent the same value; otherwise, false\. 

## Equals\(NullCheckExpressionInfo\)

### Summary

Determines whether this instance is equal to another object of the same type\.

```csharp
public bool Equals(NullCheckExpressionInfo other)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| other | An object to compare with this object\. |

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

true if the current object is equal to the **other** parameter; otherwise, false\.

#### Implements

* [IEquatable\<NullCheckExpressionInfo>.Equals](https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1.equals)