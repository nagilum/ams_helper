# Azure Media Service Helper

A C# helper class for managing assets using the Azure Media Services.

## Initialization

You'll find these values in the Azure management console under Media Services.

```csharp
const string accountName = "your-account-name";
const string accountKey = "your-account-key";

var helper = new AzureMediaServiceHelper(accountName, accountKey);
```

## Upload a File.

There are a few options available when uploading a file.
If you already have an asset ready, you can use that, which also goes for the access policy.
If not, you can easily pass the needed arguments to the function which will create both the asset and access policy for you.

```csharp
var uploadAsset = helper.UploadFile(
	"C:\example\test-video.wmv",
	Guid.NewGuid().ToString(),
	null,
	null,
	new TimeSpan(1, 0, 0),
	"1 hour policy",
	AssetCreationOptions.None,
	AzureMediaServiceHelper.AssetNameOptions.KeepOriginalName);
```

The following call will create a access policy with a duration of 1 hour, and an asset with the default options, and then upload the file to that asset.

To see a list of all assets, locators, and access policies, just use the `helper.Assets`, `helper.Locators`, and `helper.AccessPolicies` collections respectivly.

There are also functions to manage the asset in other ways such as asset file download, direct URL access, and transcoding.

## Transcoding

To transcode an asset, just pass the asset from the upload to the `TranscodeAsset` function along with the preset to use.

```csharp
var uploadAsset = helper.UploadFile(
	"C:\example\test-video.wmv",
	Guid.NewGuid().ToString(),
	null,
	null,
	new TimeSpan(1, 0, 0),
	"1 hour policy",
	AssetCreationOptions.None,
	AzureMediaServiceHelper.AssetNameOptions.KeepOriginalName);

var transcodeAsset = helper.TranscodeAsset(uploadAsset, AzureMediaServicePresets.Video.H264Broadband720p);
```

This example will upload a .wmv file and transcode into a 720p MP4 file which will be stored in its own asset.

## Download Asset Files

To download files from an asset you can either download all in one go, or cycle asset files and download each separatly.

```csharp
// This will download all files in the asset to the given folder.
helper.DownloadAsset(asset, @"C:\example\download");

// This will download a single asset file to the given folder.
helper.DownloadAssetFile(assetFile, @"C:\example\download");
```
