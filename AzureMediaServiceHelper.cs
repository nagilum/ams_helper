using Microsoft.WindowsAzure.MediaServices.Client;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Media Services conversion presets.
/// </summary>
public class AzureMediaServicePresets {
	/// <summary>
	/// Audio conversion presets.
	/// </summary>
	public class Audio {
		/// <summary>
		/// AAC Good Quality Audio
		/// </summary>
		public static string AACGoodQualityAudio { get { return "AAC Good Quality Audio"; } }

		/// <summary>
		/// WMA High Quality Audio
		/// </summary>
		public static string WMAHighQualityAudio { get { return "WMA High Quality Audio"; } }
	}

	/// <summary>
	/// Video conversion presets.
	/// </summary>
	public class Video {
		/// <summary>
		/// H264 Adaptive Bitrate MP4 Set 1080p
		/// </summary>
		public static string H264AdaptiveBitrateMP4Set1080p { get { return "H264 Adaptive Bitrate MP4 Set 1080p"; } }

		/// <summary>
		/// H264 Adaptive Bitrate MP4 Set 720p
		/// </summary>
		public static string H264AdaptiveBitrateMP4Set720p { get { return "H264 Adaptive Bitrate MP4 Set 720p"; } }

		/// <summary>
		/// H264 Adaptive Bitrate MP4 Set SD 16x9
		/// </summary>
		public static string H264AdaptiveBitrateMP4SetSD16x9 { get { return "H264 Adaptive Bitrate MP4 Set SD 16x9"; } }

		/// <summary>
		/// H264 Adaptive Bitrate MP4 Set SD 4x3
		/// </summary>
		public static string H264AdaptiveBitrateMP4SetSD4x3 { get { return "H264 Adaptive Bitrate MP4 Set SD 4x3"; } }

		/// <summary>
		/// H264 Adaptive Bitrate MP4 Set 720p for iOS Cellular Only
		/// </summary>
		public static string H264AdaptiveBitrateMP4Set720pforiOSCellularOnly { get { return "H264 Adaptive Bitrate MP4 Set 720p for iOS Cellular Only"; } }

		/// <summary>
		/// H264 Adaptive Bitrate MP4 Set 1080p for iOS Cellular Only
		/// </summary>
		public static string H264AdaptiveBitrateMP4Set1080pforiOSCellularOnly { get { return "H264 Adaptive Bitrate MP4 Set 1080p for iOS Cellular Only"; } }

		/// <summary>
		/// H264 Adaptive Bitrate MP4 Set SD 4x3 for iOS Cellular Only
		/// </summary>
		public static string H264AdaptiveBitrateMP4SetSD4x3foriOSCellularOnly { get { return "H264 Adaptive Bitrate MP4 Set SD 4x3 for iOS Cellular Only"; } }

		/// <summary>
		/// H264 Adaptive Bitrate MP4 Set SD 16x9 for iOS Cellular Only
		/// </summary>
		public static string H264AdaptiveBitrateMP4SetSD16x9foriOSCellularOnly { get { return "H264 Adaptive Bitrate MP4 Set SD 16x9 for iOS Cellular Only"; } }

		/// <summary>
		/// H264 Broadband 1080p
		/// </summary>
		public static string H264Broadband1080p { get { return "H264 Broadband 1080p"; } }

		/// <summary>
		/// H264 Broadband 720p
		/// </summary>
		public static string H264Broadband720p { get { return "H264 Broadband 720p"; } }

		/// <summary>
		/// H264 Broadband SD 16x9
		/// </summary>
		public static string H264BroadbandSD16x9 { get { return "H264 Broadband SD 16x9"; } }

		/// <summary>
		/// H264 Broadband SD 4x3
		/// </summary>
		public static string H264BroadbandSD4x3 { get { return "H264 Broadband SD 4x3"; } }

		/// <summary>
		/// H264 Smooth Streaming 1080p
		/// </summary>
		public static string H264SmoothStreaming1080p { get { return "H264 Smooth Streaming 1080p"; } }

		/// <summary>
		/// H264 Smooth Streaming 720p
		/// </summary>
		public static string H264SmoothStreaming720p { get { return "H264 Smooth Streaming 720p"; } }

		/// <summary>
		/// H264 Smooth Streaming 720p for 3G or 4G
		/// </summary>
		public static string H264SmoothStreaming720pfor3Gor4G { get { return "H264 Smooth Streaming 720p for 3G or 4G"; } }

		/// <summary>
		/// H264 Smooth Streaming 720p Xbox Live ADK
		/// </summary>
		public static string H264SmoothStreaming720pXboxLiveADK { get { return "H264 Smooth Streaming 720p Xbox Live ADK"; } }

		/// <summary>
		/// H264 Smooth Streaming SD 16x9
		/// </summary>
		public static string H264SmoothStreamingSD16x9 { get { return "H264 Smooth Streaming SD 16x9"; } }

		/// <summary>
		/// H264 Smooth Streaming SD 4x3
		/// </summary>
		public static string H264SmoothStreamingSD4x3 { get { return "H264 Smooth Streaming SD 4x3"; } }

		/// <summary>
		/// H264 Smooth Streaming Windows Phone 7 Series
		/// </summary>
		public static string H264SmoothStreamingWindowsPhone7Series { get { return "H264 Smooth Streaming Windows Phone 7 Series"; } }

		/// <summary>
		/// VC1 Broadband 1080p
		/// </summary>
		public static string VC1Broadband1080p { get { return "VC1 Broadband 1080p"; } }

		/// <summary>
		/// VC1 Broadband 720p
		/// </summary>
		public static string VC1Broadband720p { get { return "VC1 Broadband 720p"; } }

		/// <summary>
		/// VC1 Broadband SD 16x9
		/// </summary>
		public static string VC1BroadbandSD16x9 { get { return "VC1 Broadband SD 16x9"; } }

		/// <summary>
		/// VC1 Broadband SD 4x3
		/// </summary>
		public static string VC1BroadbandSD4x3 { get { return "VC1 Broadband SD 4x3"; } }

		/// <summary>
		/// VC1 Smooth Streaming 1080p
		/// </summary>
		public static string VC1SmoothStreaming1080p { get { return "VC1 Smooth Streaming 1080p"; } }

		/// <summary>
		/// VC1 Smooth Streaming 720p
		/// </summary>
		public static string VC1SmoothStreaming720p { get { return "VC1 Smooth Streaming 720p"; } }

		/// <summary>
		/// VC1 Smooth Streaming 720p Xbox Live ADK
		/// </summary>
		public static string VC1SmoothStreaming720pXboxLiveADK { get { return "VC1 Smooth Streaming 720p Xbox Live ADK"; } }

		/// <summary>
		/// VC1 Smooth Streaming SD 16x9
		/// </summary>
		public static string VC1SmoothStreamingSD16x9 { get { return "VC1 Smooth Streaming SD 16x9"; } }

		/// <summary>
		/// VC1 Smooth Streaming SD 4x3
		/// </summary>
		public static string VC1SmoothStreamingSD4x3 { get { return "VC1 Smooth Streaming SD 4x3"; } }
	}
}

/// <summary>
/// Helper class for managing asset on the Azure cloud.
/// </summary>
public class AzureMediaServiceHelper {
	/// <summary>
	/// The initialized cloud media context.
	/// </summary>
	private readonly CloudMediaContext context;

	/// <summary>
	/// Naming options for asset creation.
	/// </summary>
	public enum AssetNameOptions {
		KeepOriginalName = 1,
		CreateSafeUniqueName = 2
	}

	/// <summary>
	/// List of all assets for the active context.
	/// </summary>
	public List<IAsset> Assets {
		get {
			return this.context.Assets.ToList();
		}
	} 

	/// <summary>
	/// Initialize a new cloud media context for upload and conversion.
	/// </summary>
	/// <param name="accountName">Account name to login as.</param>
	/// <param name="accountKey">Account key to login with.</param>
	public AzureMediaServiceHelper(string accountName, string accountKey) {
		this.context = new CloudMediaContext(
			new MediaServicesCredentials(
				accountName,
				accountKey));
	}

	/// <summary>
	/// Delete an asset.
	/// </summary>
	/// <param name="asset">Source asset.</param>
	public void DeleteAsset(IAsset asset) {
		if (asset == null)
			throw new Exception("Asset cannot be null.");

		foreach (var locator in asset.Locators)
			locator.Delete();

		asset.Delete();
	}

	/// <summary>
	/// Download asset to local folder.
	/// </summary>
	/// <param name="asset">Source asset.</param>
	/// <param name="outputFolder">Folder to store file(s) in.</param>
	public void DownloadAsset(IAsset asset, string outputFolder) {
		if (asset == null)
			throw new Exception("Asset cannot be null.");

		if (!Directory.Exists(outputFolder))
			throw new DirectoryNotFoundException(outputFolder);

		var accessPolicy = this.context.AccessPolicies.Create(asset.Name, TimeSpan.FromDays(30), AccessPermissions.Read);
		var locator = this.context.Locators.CreateLocator(LocatorType.Sas, asset, accessPolicy);
		var transfer = new BlobTransferClient {
			NumberOfConcurrentTransfers = 10,
			ParallelTransferThreadCount = 10
		};

		var downloads = new List<Task>();

		foreach (var assetFile in asset.AssetFiles) {
			var localPath = Path.Combine(outputFolder, assetFile.Name);
			downloads.Add(assetFile.DownloadAsync(Path.GetFullPath(localPath), transfer, locator, CancellationToken.None));
		}

		Task.WaitAll(downloads.ToArray());
	}

	/// <summary>
	/// Builds a full download URL for first file in the asset.
	/// </summary>
	/// <param name="asset">Source asset.</param>
	/// <returns>Download URL.</returns>
	public string GetAssetFirstFileURL(IAsset asset) {
		if (asset == null)
			throw new Exception("Asset cannot be null.");

		var policy = this.context.AccessPolicies.Create(
			"30 day policy",
			TimeSpan.FromDays(30),
			AccessPermissions.Read);

		var locator = this.context.Locators.CreateLocator(
			LocatorType.Sas,
			asset,
			policy,
			DateTime.UtcNow.AddMinutes(-5));

		var assetFile = asset.AssetFiles.FirstOrDefault();

		if (assetFile == null)
			return null;

		var uri = new UriBuilder(locator.Path);
		uri.Path += "/" + assetFile.Name;

		return uri.Uri.AbsoluteUri;
	}

	/// <summary>
	/// Builds full download URL's for all files in the asset.
	/// </summary>
	/// <param name="asset">Source asset.</param>
	/// <returns>List of download URL's.</returns>
	public List<string> GetAssetAllFilesURL(IAsset asset) {
		if (asset == null)
			throw new Exception("Asset cannot be null.");

		var policy = this.context.AccessPolicies.Create(
			"30 day policy",
			TimeSpan.FromDays(30),
			AccessPermissions.Read);

		var locator = this.context.Locators.CreateLocator(
			LocatorType.Sas,
			asset,
			policy,
			DateTime.UtcNow.AddMinutes(-5));

		var uris = new List<string>();

		foreach (var assetFile in asset.AssetFiles) {
			var uri = new UriBuilder(locator.Path);
			uri.Path += "/" + assetFile.Name;
			uris.Add(uri.Uri.AbsoluteUri);
		}

		return uris;
	}

	/// <summary>
	/// Creates an encoding job using the specified preset.
	/// </summary>
	/// <param name="asset">Source asset.</param>
	/// <param name="preset">Preset name.</param>>
	/// <returns>Converted asset.</returns>
	public IAsset TranscodeAsset(IAsset asset, string preset) {
		if (asset == null)
			throw new Exception("Asset cannot be null.");

		if (string.IsNullOrWhiteSpace(preset))
			throw new Exception("Preset cannot be null.");

		var job = this.context.Jobs.Create(preset);
		var processor =
			this.context.MediaProcessors.Where(p => p.Name.Contains("Media Encoder"))
				.OrderBy(p => new Version(p.Version))
				.LastOrDefault();

		var task = job.Tasks.AddNew(
			preset,
			processor,
			preset,
			TaskOptions.ProtectedConfiguration);

		task.InputAssets.Add(asset);
		task.OutputAssets.AddNew(asset.Name, AssetCreationOptions.None);

		job.Submit();

		var progress = job.GetExecutionProgressTask(CancellationToken.None);
		progress.Wait();

		if (job.State == JobState.Error)
			throw new Exception("Unknown job error.");

		return job.OutputMediaAssets.FirstOrDefault();
	}

	/// <summary>
	/// Creates an asset and uploads a single file.
	/// </summary>
	/// <param name="filePath">File path.</param>
	/// <param name="assetCreationOptions">Options for asset creation.</param>
	/// <param name="assetNameOptions">Options for asset naming.</param>
	/// <returns>Created asset.</returns>
	public IAsset UploadFile(
		string filePath,
		AssetCreationOptions assetCreationOptions = AssetCreationOptions.None,
		AssetNameOptions assetNameOptions = AssetNameOptions.KeepOriginalName) {

		if (!File.Exists(filePath))
			throw new FileNotFoundException(filePath);

		var fileName = Path.GetFileName(filePath);

		if (string.IsNullOrWhiteSpace(fileName))
			return null;

		var assetName = (assetNameOptions == AssetNameOptions.KeepOriginalName
			? fileName
			: fileName.Replace(" ", "-") + "-" + DateTime.UtcNow.ToString(CultureInfo.InvariantCulture).Replace(" ", "-").Replace(":", "-"));

		var asset = this.context.Assets.Create(assetName, assetCreationOptions);
		var assetFile = asset.AssetFiles.Create(fileName);
		var accessPolicy = this.context.AccessPolicies.Create(assetName, TimeSpan.FromDays(30), AccessPermissions.Write | AccessPermissions.List);
		var locator = this.context.Locators.CreateLocator(LocatorType.Sas, asset, accessPolicy);

		assetFile.Upload(filePath);

		locator.Delete();
		accessPolicy.Delete();

		return asset;
	}
}