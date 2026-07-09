#### [DiGi\.Log](DiGi.Log.Overview.md 'DiGi\.Log\.Overview')

## DiGi\.Log Namespace
### Classes

<a name='DiGi.Log.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Log.Create.LogRecord(string,DiGi.Log.Enums.LogRecordType,string,object[])'></a>

## Create\.LogRecord\(string, LogRecordType, string, object\[\]\) Method

Creates a new instance of a log record\.

```csharp
public static DiGi.Log.Classes.LogRecord? LogRecord(string? id, DiGi.Log.Enums.LogRecordType logRecordType, string? format, params object[]? values);
```
#### Parameters

<a name='DiGi.Log.Create.LogRecord(string,DiGi.Log.Enums.LogRecordType,string,object[]).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The identifier for the log record\.

<a name='DiGi.Log.Create.LogRecord(string,DiGi.Log.Enums.LogRecordType,string,object[]).logRecordType'></a>

`logRecordType` [LogRecordType](DiGi.Log.Enums.md#DiGi.Log.Enums.LogRecordType 'DiGi\.Log\.Enums\.LogRecordType')

The type of the log record\.

<a name='DiGi.Log.Create.LogRecord(string,DiGi.Log.Enums.LogRecordType,string,object[]).format'></a>

`format` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The format string used to create the log message\.

<a name='DiGi.Log.Create.LogRecord(string,DiGi.Log.Enums.LogRecordType,string,object[]).values'></a>

`values` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The values to be formatted into the log message\.

#### Returns
[LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord')  
A new [LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord') instance if successful; otherwise, null\.

<a name='DiGi.Log.Create.LogRecord(string,string,DiGi.Log.Enums.LogRecordType,string,object[])'></a>

## Create\.LogRecord\(string, string, LogRecordType, string, object\[\]\) Method

Creates a log record and appends it to the specified file path\.

```csharp
public static DiGi.Log.Classes.LogRecord? LogRecord(string? path, string? id, DiGi.Log.Enums.LogRecordType logRecordType, string? format, params object[]? values);
```
#### Parameters

<a name='DiGi.Log.Create.LogRecord(string,string,DiGi.Log.Enums.LogRecordType,string,object[]).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full path to the log file\.

<a name='DiGi.Log.Create.LogRecord(string,string,DiGi.Log.Enums.LogRecordType,string,object[]).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The identifier for the log record\.

<a name='DiGi.Log.Create.LogRecord(string,string,DiGi.Log.Enums.LogRecordType,string,object[]).logRecordType'></a>

`logRecordType` [LogRecordType](DiGi.Log.Enums.md#DiGi.Log.Enums.LogRecordType 'DiGi\.Log\.Enums\.LogRecordType')

The type of the log record\.

<a name='DiGi.Log.Create.LogRecord(string,string,DiGi.Log.Enums.LogRecordType,string,object[]).format'></a>

`format` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The format string used to create the log message\.

<a name='DiGi.Log.Create.LogRecord(string,string,DiGi.Log.Enums.LogRecordType,string,object[]).values'></a>

`values` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The values to be formatted into the log message\.

#### Returns
[LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord')  
The created [LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord') if successful; otherwise, null\.

<a name='DiGi.Log.Create.LogRecord(string,System.Enum,object[])'></a>

## Create\.LogRecord\(string, Enum, object\[\]\) Method

Creates a log record based on the provided enumeration and appends it to the specified file path\.

```csharp
public static DiGi.Log.Classes.LogRecord? LogRecord(string path, System.Enum @enum, params object[] values);
```
#### Parameters

<a name='DiGi.Log.Create.LogRecord(string,System.Enum,object[]).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full path to the log file\.

<a name='DiGi.Log.Create.LogRecord(string,System.Enum,object[]).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value used to retrieve log properties\.

<a name='DiGi.Log.Create.LogRecord(string,System.Enum,object[]).values'></a>

`values` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The values to be formatted into the log message\.

#### Returns
[LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord')  
The created [LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord') if successful; otherwise, null\.

<a name='DiGi.Log.Create.LogRecord(System.Enum,object[])'></a>

## Create\.LogRecord\(Enum, object\[\]\) Method

Creates a new instance of a log record based on the provided enumeration\.

```csharp
public static DiGi.Log.Classes.LogRecord? LogRecord(System.Enum? @enum, params object[] values);
```
#### Parameters

<a name='DiGi.Log.Create.LogRecord(System.Enum,object[]).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value used to retrieve log properties\.

<a name='DiGi.Log.Create.LogRecord(System.Enum,object[]).values'></a>

`values` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The values to be formatted into the log message\.

#### Returns
[LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord')  
A new [LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord') instance if successful; otherwise, null\.

<a name='DiGi.Log.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Log.Query.LogRecordProperties(thisSystem.Enum)'></a>

## Query\.LogRecordProperties\(this Enum\) Method

Retrieves the [LogRecordProperties\(this Enum\)](DiGi.Log.md#DiGi.Log.Query.LogRecordProperties(thisSystem.Enum) 'DiGi\.Log\.Query\.LogRecordProperties\(this System\.Enum\)') attribute associated with the specified enumeration value\.

```csharp
public static DiGi.Log.Classes.LogRecordProperties? LogRecordProperties(this System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Log.Query.LogRecordProperties(thisSystem.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value to query for properties\.

#### Returns
[LogRecordProperties](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecordProperties 'DiGi\.Log\.Classes\.LogRecordProperties')  
The [LogRecordProperties\(this Enum\)](DiGi.Log.md#DiGi.Log.Query.LogRecordProperties(thisSystem.Enum) 'DiGi\.Log\.Query\.LogRecordProperties\(this System\.Enum\)') attribute if found; otherwise, `null`\.