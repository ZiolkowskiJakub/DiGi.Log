#### [DiGi\.Log](index.md 'index')

## DiGi\.Log\.Classes Namespace
### Classes

<a name='DiGi.Log.Classes.Log'></a>

## Log Class

Represents a standard log collection using [LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord') entries\.

```csharp
public class Log : DiGi.Log.Classes.Log<DiGi.Log.Classes.LogRecord>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Log\.Classes\.Log&lt;](DiGi.Log.Classes.md#DiGi.Log.Classes.Log_T_ 'DiGi\.Log\.Classes\.Log\<T\>')[LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord')[&gt;](DiGi.Log.Classes.md#DiGi.Log.Classes.Log_T_ 'DiGi\.Log\.Classes\.Log\<T\>') → Log
### Constructors

<a name='DiGi.Log.Classes.Log.Log()'></a>

## Log\(\) Constructor

Initializes a new instance of the [Log](DiGi.Log.Classes.md#DiGi.Log.Classes.Log 'DiGi\.Log\.Classes\.Log') class\.

```csharp
public Log();
```

<a name='DiGi.Log.Classes.Log.Log(DiGi.Log.Classes.Log)'></a>

## Log\(Log\) Constructor

Initializes a new instance of the [Log](DiGi.Log.Classes.md#DiGi.Log.Classes.Log 'DiGi\.Log\.Classes\.Log') class by cloning an existing log object\.

```csharp
public Log(DiGi.Log.Classes.Log? log);
```
#### Parameters

<a name='DiGi.Log.Classes.Log.Log(DiGi.Log.Classes.Log).log'></a>

`log` [Log](DiGi.Log.Classes.md#DiGi.Log.Classes.Log 'DiGi\.Log\.Classes\.Log')

The source log object to clone\.

<a name='DiGi.Log.Classes.Log.Log(System.Collections.Generic.IEnumerable_DiGi.Log.Classes.LogRecord_)'></a>

## Log\(IEnumerable\<LogRecord\>\) Constructor

Initializes a new instance of the [Log](DiGi.Log.Classes.md#DiGi.Log.Classes.Log 'DiGi\.Log\.Classes\.Log') class with a specified collection of log records\.

```csharp
public Log(System.Collections.Generic.IEnumerable<DiGi.Log.Classes.LogRecord>? logRecords);
```
#### Parameters

<a name='DiGi.Log.Classes.Log.Log(System.Collections.Generic.IEnumerable_DiGi.Log.Classes.LogRecord_).logRecords'></a>

`logRecords` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The initial collection of log records to populate the log\.

<a name='DiGi.Log.Classes.Log.Log(System.Text.Json.Nodes.JsonObject)'></a>

## Log\(JsonObject\) Constructor

Initializes a new instance of the [Log](DiGi.Log.Classes.md#DiGi.Log.Classes.Log 'DiGi\.Log\.Classes\.Log') class from a JSON object\.

```csharp
public Log(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Log.Classes.Log.Log(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing log data\.
### Methods

<a name='DiGi.Log.Classes.Log.Add(DiGi.Log.Classes.LogRecord)'></a>

## Log\.Add\(LogRecord\) Method

Adds a new log record to the collection after cloning it\.

```csharp
public DiGi.Log.Classes.LogRecord? Add(DiGi.Log.Classes.LogRecord? logRecord);
```
#### Parameters

<a name='DiGi.Log.Classes.Log.Add(DiGi.Log.Classes.LogRecord).logRecord'></a>

`logRecord` [LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord')

The log record to add\.

#### Returns
[LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord')  
The added log record, or null if the input was null\.

<a name='DiGi.Log.Classes.Log.Add(DiGi.Log.Enums.LogRecordType,string,object[])'></a>

## Log\.Add\(LogRecordType, string, object\[\]\) Method

Creates and adds a new log record based on the specified type and format\.

```csharp
public DiGi.Log.Classes.LogRecord? Add(DiGi.Log.Enums.LogRecordType logRecordType, string format, params object[] values);
```
#### Parameters

<a name='DiGi.Log.Classes.Log.Add(DiGi.Log.Enums.LogRecordType,string,object[]).logRecordType'></a>

`logRecordType` [LogRecordType](DiGi.Log.Enums.md#DiGi.Log.Enums.LogRecordType 'DiGi\.Log\.Enums\.LogRecordType')

The type of the log record\.

<a name='DiGi.Log.Classes.Log.Add(DiGi.Log.Enums.LogRecordType,string,object[]).format'></a>

`format` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The format string for the log message\.

<a name='DiGi.Log.Classes.Log.Add(DiGi.Log.Enums.LogRecordType,string,object[]).values'></a>

`values` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The values to be formatted into the message\.

#### Returns
[LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord')  
The created and added log record\.

<a name='DiGi.Log.Classes.Log.AddRange(System.Collections.Generic.IEnumerable_DiGi.Log.Classes.LogRecord_)'></a>

## Log\.AddRange\(IEnumerable\<LogRecord\>\) Method

Adds a range of log records to the collection\.

```csharp
public System.Collections.Generic.List<DiGi.Log.Classes.LogRecord>? AddRange(System.Collections.Generic.IEnumerable<DiGi.Log.Classes.LogRecord>? logRecords);
```
#### Parameters

<a name='DiGi.Log.Classes.Log.AddRange(System.Collections.Generic.IEnumerable_DiGi.Log.Classes.LogRecord_).logRecords'></a>

`logRecords` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of log records to add\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of successfully added log records, or null if the input was null\.

<a name='DiGi.Log.Classes.Log.Clone()'></a>

## Log\.Clone\(\) Method

Creates a shallow copy of the current log instance\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') representing the log\.

<a name='DiGi.Log.Classes.Log_T_'></a>

## Log\<T\> Class

Represents a base collection of log records\.

```csharp
public abstract class Log<T> : DiGi.Core.Classes.SerializableObject, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    where T : DiGi.Log.Interfaces.ILogRecord
```
#### Type parameters

<a name='DiGi.Log.Classes.Log_T_.T'></a>

`T`

The type of log record, which must implement [ILogRecord](DiGi.Log.Interfaces.md#DiGi.Log.Interfaces.ILogRecord 'DiGi\.Log\.Interfaces\.ILogRecord')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Log\<T\>

Derived  
↳ [Log](DiGi.Log.Classes.md#DiGi.Log.Classes.Log 'DiGi\.Log\.Classes\.Log')

Implements [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Log.Classes.md#DiGi.Log.Classes.Log_T_.T 'DiGi\.Log\.Classes\.Log\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')
### Constructors

<a name='DiGi.Log.Classes.Log_T_.Log()'></a>

## Log\(\) Constructor

Initializes a new instance of the [Log&lt;T&gt;](DiGi.Log.Classes.md#DiGi.Log.Classes.Log_T_ 'DiGi\.Log\.Classes\.Log\<T\>') class\.

```csharp
public Log();
```

<a name='DiGi.Log.Classes.Log_T_.Log(DiGi.Log.Classes.Log_T_)'></a>

## Log\(Log\<T\>\) Constructor

Initializes a new instance of the [Log&lt;T&gt;](DiGi.Log.Classes.md#DiGi.Log.Classes.Log_T_ 'DiGi\.Log\.Classes\.Log\<T\>') class by cloning an existing log object\.

```csharp
public Log(DiGi.Log.Classes.Log<T>? log);
```
#### Parameters

<a name='DiGi.Log.Classes.Log_T_.Log(DiGi.Log.Classes.Log_T_).log'></a>

`log` [DiGi\.Log\.Classes\.Log&lt;](DiGi.Log.Classes.md#DiGi.Log.Classes.Log_T_ 'DiGi\.Log\.Classes\.Log\<T\>')[T](DiGi.Log.Classes.md#DiGi.Log.Classes.Log_T_.T 'DiGi\.Log\.Classes\.Log\<T\>\.T')[&gt;](DiGi.Log.Classes.md#DiGi.Log.Classes.Log_T_ 'DiGi\.Log\.Classes\.Log\<T\>')

The source log object to clone\.

<a name='DiGi.Log.Classes.Log_T_.Log(System.Collections.Generic.IEnumerable_T_)'></a>

## Log\(IEnumerable\<T\>\) Constructor

Initializes a new instance of the [Log&lt;T&gt;](DiGi.Log.Classes.md#DiGi.Log.Classes.Log_T_ 'DiGi\.Log\.Classes\.Log\<T\>') class with a specified collection of log records\.

```csharp
public Log(System.Collections.Generic.IEnumerable<T>? logRecords);
```
#### Parameters

<a name='DiGi.Log.Classes.Log_T_.Log(System.Collections.Generic.IEnumerable_T_).logRecords'></a>

`logRecords` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Log.Classes.md#DiGi.Log.Classes.Log_T_.T 'DiGi\.Log\.Classes\.Log\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The initial collection of log records to populate the log\.

<a name='DiGi.Log.Classes.Log_T_.Log(System.Text.Json.Nodes.JsonObject)'></a>

## Log\(JsonObject\) Constructor

Initializes a new instance of the [Log&lt;T&gt;](DiGi.Log.Classes.md#DiGi.Log.Classes.Log_T_ 'DiGi\.Log\.Classes\.Log\<T\>') class from a JSON object\.

```csharp
public Log(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Log.Classes.Log_T_.Log(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing log data\.
### Fields

<a name='DiGi.Log.Classes.Log_T_.logRecords'></a>

## Log\<T\>\.logRecords Field

The internal list of log records\.

```csharp
protected List<T> logRecords;
```

#### Field Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Log.Classes.md#DiGi.Log.Classes.Log_T_.T 'DiGi\.Log\.Classes\.Log\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Log.Classes.Log_T_.GetEnumerator()'></a>

## Log\<T\>\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the collection of log records\.

```csharp
public System.Collections.Generic.IEnumerator<T> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator 'System\.Collections\.Generic\.IEnumerable\`1\.GetEnumerator'), [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[T](DiGi.Log.Classes.md#DiGi.Log.Classes.Log_T_.T 'DiGi\.Log\.Classes\.Log\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
A typed enumerator for [T](DiGi.Log.Classes.md#DiGi.Log.Classes.Log_T_.T 'DiGi\.Log\.Classes\.Log\<T\>\.T')\.

<a name='DiGi.Log.Classes.Log_T_.ToString()'></a>

## Log\<T\>\.ToString\(\) Method

Returns a string representation of all log records, separated by environment new lines\.

```csharp
public override string? ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A concatenated string of all log records, or null if the record list is null\.

<a name='DiGi.Log.Classes.Log_T_.Write(string)'></a>

## Log\<T\>\.Write\(string\) Method

Writes the contents of the log to a specified file path\.

```csharp
public bool Write(string? path);
```
#### Parameters

<a name='DiGi.Log.Classes.Log_T_.Write(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The destination file path\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the write operation was successful; otherwise, false\.
### Explicit Interface Implementations

<a name='DiGi.Log.Classes.Log_T_.System.Collections.IEnumerable.GetEnumerator()'></a>

## System\.Collections\.IEnumerable\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the collection of log records\.

```csharp
System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

<a name='DiGi.Log.Classes.LogRecord'></a>

## LogRecord Class

Represents a log record entry containing timestamp, identification, type, and message text\.

```csharp
public class LogRecord : DiGi.Core.Classes.SerializableObject, DiGi.Log.Interfaces.ILogRecord, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → LogRecord

Implements [ILogRecord](DiGi.Log.Interfaces.md#DiGi.Log.Interfaces.ILogRecord 'DiGi\.Log\.Interfaces\.ILogRecord'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Log.Classes.LogRecord.LogRecord(DiGi.Log.Classes.LogRecord)'></a>

## LogRecord\(LogRecord\) Constructor

Initializes a new instance of the [LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord') class by copying an existing record\.

```csharp
public LogRecord(DiGi.Log.Classes.LogRecord? logRecord);
```
#### Parameters

<a name='DiGi.Log.Classes.LogRecord.LogRecord(DiGi.Log.Classes.LogRecord).logRecord'></a>

`logRecord` [LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord')

The source log record to copy from\.

<a name='DiGi.Log.Classes.LogRecord.LogRecord(DiGi.Log.Enums.LogRecordType,string)'></a>

## LogRecord\(LogRecordType, string\) Constructor

Initializes a new instance of the [LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord') class using current UTC time and no identifier\.

```csharp
public LogRecord(DiGi.Log.Enums.LogRecordType logRecordType, string? text);
```
#### Parameters

<a name='DiGi.Log.Classes.LogRecord.LogRecord(DiGi.Log.Enums.LogRecordType,string).logRecordType'></a>

`logRecordType` [LogRecordType](DiGi.Log.Enums.md#DiGi.Log.Enums.LogRecordType 'DiGi\.Log\.Enums\.LogRecordType')

The type or severity of the log record\.

<a name='DiGi.Log.Classes.LogRecord.LogRecord(DiGi.Log.Enums.LogRecordType,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive text of the log message\.

<a name='DiGi.Log.Classes.LogRecord.LogRecord(string,DiGi.Log.Enums.LogRecordType,string)'></a>

## LogRecord\(string, LogRecordType, string\) Constructor

Initializes a new instance of the [LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord') class using the current UTC time\.

```csharp
public LogRecord(string? id, DiGi.Log.Enums.LogRecordType logRecordType, string? text);
```
#### Parameters

<a name='DiGi.Log.Classes.LogRecord.LogRecord(string,DiGi.Log.Enums.LogRecordType,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the record\.

<a name='DiGi.Log.Classes.LogRecord.LogRecord(string,DiGi.Log.Enums.LogRecordType,string).logRecordType'></a>

`logRecordType` [LogRecordType](DiGi.Log.Enums.md#DiGi.Log.Enums.LogRecordType 'DiGi\.Log\.Enums\.LogRecordType')

The type or severity of the log record\.

<a name='DiGi.Log.Classes.LogRecord.LogRecord(string,DiGi.Log.Enums.LogRecordType,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive text of the log message\.

<a name='DiGi.Log.Classes.LogRecord.LogRecord(System.DateTime,DiGi.Log.Enums.LogRecordType,string)'></a>

## LogRecord\(DateTime, LogRecordType, string\) Constructor

Initializes a new instance of the [LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord') class without an identifier\.

```csharp
public LogRecord(System.DateTime dateTime, DiGi.Log.Enums.LogRecordType logRecordType, string? text);
```
#### Parameters

<a name='DiGi.Log.Classes.LogRecord.LogRecord(System.DateTime,DiGi.Log.Enums.LogRecordType,string).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The timestamp of the log entry\.

<a name='DiGi.Log.Classes.LogRecord.LogRecord(System.DateTime,DiGi.Log.Enums.LogRecordType,string).logRecordType'></a>

`logRecordType` [LogRecordType](DiGi.Log.Enums.md#DiGi.Log.Enums.LogRecordType 'DiGi\.Log\.Enums\.LogRecordType')

The type or severity of the log record\.

<a name='DiGi.Log.Classes.LogRecord.LogRecord(System.DateTime,DiGi.Log.Enums.LogRecordType,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive text of the log message\.

<a name='DiGi.Log.Classes.LogRecord.LogRecord(System.DateTime,string,DiGi.Log.Enums.LogRecordType,string)'></a>

## LogRecord\(DateTime, string, LogRecordType, string\) Constructor

Initializes a new instance of the [LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord') class with all specified values\.

```csharp
public LogRecord(System.DateTime dateTime, string? id, DiGi.Log.Enums.LogRecordType logRecordType, string? text);
```
#### Parameters

<a name='DiGi.Log.Classes.LogRecord.LogRecord(System.DateTime,string,DiGi.Log.Enums.LogRecordType,string).dateTime'></a>

`dateTime` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The timestamp of the log entry\.

<a name='DiGi.Log.Classes.LogRecord.LogRecord(System.DateTime,string,DiGi.Log.Enums.LogRecordType,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the record\.

<a name='DiGi.Log.Classes.LogRecord.LogRecord(System.DateTime,string,DiGi.Log.Enums.LogRecordType,string).logRecordType'></a>

`logRecordType` [LogRecordType](DiGi.Log.Enums.md#DiGi.Log.Enums.LogRecordType 'DiGi\.Log\.Enums\.LogRecordType')

The type or severity of the log record\.

<a name='DiGi.Log.Classes.LogRecord.LogRecord(System.DateTime,string,DiGi.Log.Enums.LogRecordType,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive text of the log message\.

<a name='DiGi.Log.Classes.LogRecord.LogRecord(System.Text.Json.Nodes.JsonObject)'></a>

## LogRecord\(JsonObject\) Constructor

Initializes a new instance of the [LogRecord](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecord 'DiGi\.Log\.Classes\.LogRecord') class from a JSON object\.

```csharp
public LogRecord(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Log.Classes.LogRecord.LogRecord(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing record data\.
### Properties

<a name='DiGi.Log.Classes.LogRecord.DateTime'></a>

## LogRecord\.DateTime Property

Gets the timestamp when the log record was created\.

```csharp
public System.DateTime DateTime { get; }
```

Implements [DateTime](DiGi.Log.Interfaces.md#DiGi.Log.Interfaces.ILogRecord.DateTime 'DiGi\.Log\.Interfaces\.ILogRecord\.DateTime')

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.Log.Classes.LogRecord.Id'></a>

## LogRecord\.Id Property

Gets the unique identifier of the log record\.

```csharp
public string? Id { get; }
```

Implements [Id](DiGi.Log.Interfaces.md#DiGi.Log.Interfaces.ILogRecord.Id 'DiGi\.Log\.Interfaces\.ILogRecord\.Id')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Log.Classes.LogRecord.LogRecordType'></a>

## LogRecord\.LogRecordType Property

Gets the type or severity level of the log record\.

```csharp
public DiGi.Log.Enums.LogRecordType LogRecordType { get; }
```

Implements [LogRecordType](DiGi.Log.Interfaces.md#DiGi.Log.Interfaces.ILogRecord.LogRecordType 'DiGi\.Log\.Interfaces\.ILogRecord\.LogRecordType')

#### Property Value
[LogRecordType](DiGi.Log.Enums.md#DiGi.Log.Enums.LogRecordType 'DiGi\.Log\.Enums\.LogRecordType')

<a name='DiGi.Log.Classes.LogRecord.Text'></a>

## LogRecord\.Text Property

Gets the message text associated with the log record\.

```csharp
public string? Text { get; }
```

Implements [Text](DiGi.Log.Interfaces.md#DiGi.Log.Interfaces.ILogRecord.Text 'DiGi\.Log\.Interfaces\.ILogRecord\.Text')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Log.Classes.LogRecord.Clone()'></a>

## LogRecord\.Clone\(\) Method

Creates a clone of the current log record\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') instance that is a copy of this record\.

<a name='DiGi.Log.Classes.LogRecord.GetHashCode()'></a>

## LogRecord\.GetHashCode\(\) Method

Returns a hash code for the current log record based on its string representation\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An integer hash code\.

<a name='DiGi.Log.Classes.LogRecord.ToString()'></a>

## LogRecord\.ToString\(\) Method

Returns a string representation of the log record, formatted with tabs\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A formatted string containing the date, ID \(if available\), type description, and text\.

<a name='DiGi.Log.Classes.LogRecordProperties'></a>

## LogRecordProperties Class

Attribute used to define properties for a log record field\.

```csharp
public class LogRecordProperties : System.Attribute
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → LogRecordProperties
### Constructors

<a name='DiGi.Log.Classes.LogRecordProperties.LogRecordProperties(DiGi.Log.Enums.LogRecordType,string)'></a>

## LogRecordProperties\(LogRecordType, string\) Constructor

Initializes a new instance of the [LogRecordProperties](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecordProperties 'DiGi\.Log\.Classes\.LogRecordProperties') class\.

```csharp
public LogRecordProperties(DiGi.Log.Enums.LogRecordType logRecordType, string? text);
```
#### Parameters

<a name='DiGi.Log.Classes.LogRecordProperties.LogRecordProperties(DiGi.Log.Enums.LogRecordType,string).logRecordType'></a>

`logRecordType` [LogRecordType](DiGi.Log.Enums.md#DiGi.Log.Enums.LogRecordType 'DiGi\.Log\.Enums\.LogRecordType')

The type of the log record\.

<a name='DiGi.Log.Classes.LogRecordProperties.LogRecordProperties(DiGi.Log.Enums.LogRecordType,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive text associated with the log record\.

<a name='DiGi.Log.Classes.LogRecordProperties.LogRecordProperties(string,DiGi.Log.Enums.LogRecordType,string)'></a>

## LogRecordProperties\(string, LogRecordType, string\) Constructor

Initializes a new instance of the [LogRecordProperties](DiGi.Log.Classes.md#DiGi.Log.Classes.LogRecordProperties 'DiGi\.Log\.Classes\.LogRecordProperties') class\.

```csharp
public LogRecordProperties(string? id, DiGi.Log.Enums.LogRecordType logRecordType, string? text);
```
#### Parameters

<a name='DiGi.Log.Classes.LogRecordProperties.LogRecordProperties(string,DiGi.Log.Enums.LogRecordType,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the log record property\.

<a name='DiGi.Log.Classes.LogRecordProperties.LogRecordProperties(string,DiGi.Log.Enums.LogRecordType,string).logRecordType'></a>

`logRecordType` [LogRecordType](DiGi.Log.Enums.md#DiGi.Log.Enums.LogRecordType 'DiGi\.Log\.Enums\.LogRecordType')

The type of the log record\.

<a name='DiGi.Log.Classes.LogRecordProperties.LogRecordProperties(string,DiGi.Log.Enums.LogRecordType,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive text associated with the log record\.
### Properties

<a name='DiGi.Log.Classes.LogRecordProperties.Id'></a>

## LogRecordProperties\.Id Property

Gets the unique identifier for the log record property\.

```csharp
public string? Id { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Log.Classes.LogRecordProperties.LogRecordType'></a>

## LogRecordProperties\.LogRecordType Property

Gets the type of the log record\.

```csharp
public DiGi.Log.Enums.LogRecordType LogRecordType { get; }
```

#### Property Value
[LogRecordType](DiGi.Log.Enums.md#DiGi.Log.Enums.LogRecordType 'DiGi\.Log\.Enums\.LogRecordType')

<a name='DiGi.Log.Classes.LogRecordProperties.Text'></a>

## LogRecordProperties\.Text Property

Gets the descriptive text associated with the log record\.

```csharp
public string? Text { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')