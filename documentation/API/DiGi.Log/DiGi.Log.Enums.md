#### [DiGi\.Log](DiGi.Log.Overview.md 'DiGi\.Log\.Overview')

## DiGi\.Log\.Enums Namespace
### Enums

<a name='DiGi.Log.Enums.DefaultLogRecord'></a>

## DefaultLogRecord Enum

Defines the default set of log records used for system logging\.

```csharp
public enum DefaultLogRecord
```
### Fields

<a name='DiGi.Log.Enums.DefaultLogRecord.Start'></a>

`Start` 0

Indicates the start of a process or operation\.

<a name='DiGi.Log.Enums.DefaultLogRecord.Stop'></a>

`Stop` 1

Indicates the stop or completion of a process or operation\.

<a name='DiGi.Log.Enums.DefaultLogRecord.Warning'></a>

`Warning` 2

Indicates a warning event that does not necessarily interrupt the flow of execution\.

<a name='DiGi.Log.Enums.DefaultLogRecord.Error'></a>

`Error` 3

Indicates an error event that may impact the system's functionality\.

<a name='DiGi.Log.Enums.LogRecordType'></a>

## LogRecordType Enum

Specifies the type of a log record\.

```csharp
public enum LogRecordType
```
### Fields

<a name='DiGi.Log.Enums.LogRecordType.Undefined'></a>

`Undefined` 0

The log record type is undefined\.

<a name='DiGi.Log.Enums.LogRecordType.Message'></a>

`Message` 1

A general informational message\.

<a name='DiGi.Log.Enums.LogRecordType.Warning'></a>

`Warning` 2

A warning indicating a potential issue that does not stop the application\.

<a name='DiGi.Log.Enums.LogRecordType.Error'></a>

`Error` 3

An error indicating a failure in the application\.