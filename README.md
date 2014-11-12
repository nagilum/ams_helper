# Azure Media Service Helper

A C# helper class for managing assets using the Azure Media Services.

## Initialization

You'll find these values in the Azure management console under Media Services.

```csharp
const string accountName = "your-account-name";
const string accountKey = "your-account-key";

var helper = new AzureMediaServiceHelper(accountName, accountKey);
```

## Upload a file.

There are a few options available when uploading a file.
If you already have an asset ready, you can use that, which also goes for the access policy.
If not, you can easily pass the needed arguments to the function which will create both the asset and access policy for you.

```csharp
helper.UploadFile(
	"C:\example\test-video.wmv",
	new TimeSpan(0, 1, 0));
```

The following call will create a access policy with a duration of 1 minute, and an asset with the default options, and then upload the file to that asset.

To see a list of all assets, locators, and access policies, just use the `helper.Assets`, `helper.Locators`, and `helper.AccessPolicies` collections respectivly.

There are also functions to manage the asset in other ways.
