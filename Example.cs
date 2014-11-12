using Microsoft.WindowsAzure.MediaServices.Client;
using System;
using System.IO;
using System.Linq;

public class Program {
	static void Main() {
		// Get these variables from the Azure management console.
		const string accountName = "accountnamefromazureconsole";
		const string accountKey = "v6123563549KnN5PFanewlkaqJCUt8OCocdeftNIGJrdABaeuQ=";

		// Init a new instance of the helper class.
		var helper = new AzureMediaServiceHelper(accountName, accountKey);

		// Print all assets and files attached to the active context.
		Console.WriteLine("Assets:");

		foreach (var tempAsset in helper.Assets) {
			Console.WriteLine(" - " + tempAsset.Name);

			foreach (var tempAssetFile in tempAsset.AssetFiles)
				Console.WriteLine("   + " + tempAssetFile.Name);

			Console.WriteLine("");
		}

		// Upload a new file to the cloud.
		var path = Path.GetFullPath("media");
		var file = Path.Combine(path, "video.wmv");
		var guid = Guid.NewGuid().ToString();

		var uploadAsset = helper.UploadFile(
			file,
			guid,
			null,
			null,
			new TimeSpan(1, 0, 0),
			"1 hour policy",
			AssetCreationOptions.None,
			AzureMediaServiceHelper.AssetNameOptions.KeepOriginalName);

		// Transcode the .wmv file to a 720p .mp4.
		var transcodeAsset = helper.TranscodeAsset(
			uploadAsset,
			AzureMediaServicePresets.Video.H264Broadband720p);

		// Download the newly created .mp4 file.
		foreach (var assetFile in transcodeAsset.AssetFiles.Where(f => f.Name.EndsWith(".mp4", StringComparison.OrdinalIgnoreCase)))
			helper.DownloadAssetFile(assetFile, Path.GetFullPath(@"media\download"));
	}
}