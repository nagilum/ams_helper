# Azure Media Service Helper

A C# helper class for managing assets using the Azure Media Services.

## Initialization

You'll find these values in the Azure management console under Media Services.

```csharp
const string accountName = "your-account-name";
const string accountKey = "your-account-key";

var helper = new AzureMediaServiceHelper(accountName, accountKey);
```
