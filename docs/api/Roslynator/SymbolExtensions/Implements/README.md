# SymbolExtensions\.Implements Method

**Namespace**: [Roslynator](../../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| Implements\(ITypeSymbol, INamedTypeSymbol, Boolean\) | Returns true if the type implements specified interface\. |
| Implements\(ITypeSymbol, SpecialType, Boolean\) | Returns true if the type implements specified interface\. |

## Implements\(ITypeSymbol, SpecialType, Boolean\)

### Summary

Returns true if the type implements specified interface\.

```csharp
public static bool Implements(this ITypeSymbol typeSymbol, SpecialType interfaceType, bool allInterfaces = false)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| typeSymbol | |
| interfaceType | |
| allInterfaces | If true, use [ITypeSymbol.AllInterfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.allinterfaces), otherwise use [ITypeSymbol.Interfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.interfaces)\. |

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

## Implements\(ITypeSymbol, INamedTypeSymbol, Boolean\)

### Summary

Returns true if the type implements specified interface\.

```csharp
public static bool Implements(this ITypeSymbol typeSymbol, INamedTypeSymbol interfaceSymbol, bool allInterfaces = false)
```

#### Parameters

| Name | Summary |
| ---- | ------- |
| typeSymbol | |
| interfaceSymbol | |
| allInterfaces | If true, use [ITypeSymbol.AllInterfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.allinterfaces), otherwise use [ITypeSymbol.Interfaces](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.interfaces)\. |

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

