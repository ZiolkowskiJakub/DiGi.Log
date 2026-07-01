#### [DiGi\.Log](index.md 'index')

## DiGi\.Log\.Interfaces Namespace
### Interfaces

<a name='DiGi.Log.Interfaces.ILogRecord'></a>

## ILogRecord Interface

Defines the contract for a log record entry\.

```csharp
public interface ILogRecord : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord')

Implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Log.Interfaces.ILogRecord.DateTime'></a>

## ILogRecord\.DateTime Property

Gets the date and time when the log record was created\.

```csharp
System.DateTime DateTime { get; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.Log.Interfaces.ILogRecord.Id'></a>

## ILogRecord\.Id Property

Gets the unique identifier of the log record\.

```csharp
string? Id { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Log.Interfaces.ILogRecord.LogRecordType'></a>

## ILogRecord\.LogRecordType Property

Gets the type or severity level of the log record\.

```csharp
DiGi.Log.Enums.LogRecordType LogRecordType { get; }
```

#### Property Value
[LogRecordType](DiGi.Log.Enums.md#DiGi.Log.Enums.LogRecordType 'DiGi\.Log\.Enums\.LogRecordType')

<a name='DiGi.Log.Interfaces.ILogRecord.Text'></a>

## ILogRecord\.Text Property

Gets the text content of the log record\.

```csharp
string? Text { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')