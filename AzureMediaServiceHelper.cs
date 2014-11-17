using Microsoft.WindowsAzure.MediaServices.Client;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

/// <summary>
/// Azure Media Services conversion presets.
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
/// Helper class for managing assets using the Azure Media Services.
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
	/// Collection of all assets for active context.
	/// </summary>
	public AssetBaseCollection Assets {
		get { return this.context.Assets; }
	}

	/// <summary>
	/// Collection of all locators for active context.
	/// </summary>
	public LocatorBaseCollection Locators {
		get { return this.context.Locators; }
	}

	/// <summary>
	/// Collection of all access policies for active context.
	/// </summary>
	public AccessPolicyBaseCollection AccessPolicies {
		get { return this.context.AccessPolicies; }
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
	/// Download all files attached to an asset.
	/// </summary>
	/// <param name="asset">Source asset.</param>
	/// <param name="outputFolder">Folder to store file(s) in.</param>
	public void DownloadAsset(IAsset asset, string outputFolder) {
		if (asset == null)
			throw new Exception("Asset cannot be null.");

		if (!Directory.Exists(outputFolder))
			throw new DirectoryNotFoundException(outputFolder);

		foreach (var assetFile in asset.AssetFiles)
			this.DownloadAssetFile(assetFile, outputFolder);
	}

	/// <summary>
	/// Download a single asset file.
	/// </summary>
	/// <param name="assetFile">Asset file to download.</param>
	/// <param name="outputFolder">Folder to store file in.</param>
	public void DownloadAssetFile(IAssetFile assetFile, string outputFolder) {
		if (assetFile == null)
			throw new Exception("Asset file cannot be null.");

		if (!Directory.Exists(outputFolder))
			throw new DirectoryNotFoundException(outputFolder);

		assetFile.Download(Path.Combine(outputFolder, assetFile.Name));
	}

	/// <summary>
	/// Retrieve the download file URL for an asset file.
	/// </summary>
	/// <param name="assetFile">Asset file.</param>
	/// <param name="accessPolicy">Access policy to use.</param>
	/// <returns>Download URL.</returns>
	public string GetAssetFileURL(IAssetFile assetFile, IAccessPolicy accessPolicy) {
		if (assetFile == null)
			throw new Exception("Asset File cannot be null.");

		// Create locator.
		var locator = this.context.Locators.CreateLocator(
			LocatorType.Sas,
			assetFile.Asset,
			accessPolicy,
			DateTime.UtcNow.AddMinutes(-5));

		// Create and return URi.
		var builder = new UriBuilder(locator.Path);
		builder.Path += "/" + assetFile.Name;

		return builder.Uri.AbsoluteUri;
	}

	/// <summary>
	/// Retrieve the download file URL for an asset file.
	/// </summary>
	/// <param name="assetFile">Asset file.</param>
	/// <param name="accessPolicyDuration">Length of access policy.</param>
	/// <returns>Download URL.</returns>
	public string GetAssetFileURL(IAssetFile assetFile, TimeSpan accessPolicyDuration) {
		if (assetFile == null)
			throw new Exception("Asset File cannot be null.");

		// Create access policy.
		var accessPolicy = this.context.AccessPolicies.Create(
			accessPolicyDuration + " policy",
			accessPolicyDuration,
			AccessPermissions.Read);

		// Forward to function.
		return this.GetAssetFileURL(assetFile, accessPolicy);
	}

	/// <summary>
	/// Retrieve the streaming URL for an asset file.
	/// </summary>
	/// <param name="asset">Asset.</param>
	/// <param name="accessPolicy">Access policy to use.</param>
	/// <returns>Streaming URL.</returns>
	public string GetAssetFileStreamingURL(IAsset asset, IAccessPolicy accessPolicy) {
		if (asset == null)
			throw new Exception("Asset cannot be null.");

		var manifest = asset.AssetFiles.FirstOrDefault(f => f.Name.EndsWith(".ism"));

		if (manifest == null)
			return null;

		// Create locator.
		var locator = this.context.Locators.CreateLocator(
			LocatorType.OnDemandOrigin,
			asset,
			accessPolicy,
			DateTime.UtcNow.AddMinutes(-5));

		// Return URL.
		return
			locator.Path +
			manifest.Name +
			"/Manifest";
	}

	/// <summary>
	/// Retrieve the streaming URL for an asset file.
	/// </summary>
	/// <param name="asset">Asset.</param>
	/// <param name="accessPolicyDuration">Length of access policy.</param>
	/// <returns>Streaming URL.</returns>
	public string GetAssetFileStreamingURL(IAsset asset, TimeSpan accessPolicyDuration) {
		if (asset == null)
			throw new Exception("Asset cannot be null.");

		// Create access policy.
		var accessPolicy = this.context.AccessPolicies.Create(
			accessPolicyDuration + " policy",
			accessPolicyDuration,
			AccessPermissions.Read);

		// Forward to function.
		return this.GetAssetFileStreamingURL(asset, accessPolicy);
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
			this.context.MediaProcessors
				.Where(p => p.Name.Contains("Media Encoder"))
				.ToList()
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
	/// Uploads a file using the given asset and access policy.
	/// </summary>
	/// <param name="filePath">File path.</param>
	/// <param name="asset">Asset to utilize.</param>
	/// <param name="accessPolicy">Access policy to utilize.</param>
	/// <returns>Asset.</returns>
	public IAsset UploadFile(string filePath, IAsset asset, IAccessPolicy accessPolicy) {
		// Get filename from path.
		var fileName = Path.GetFileName(filePath);

		if (string.IsNullOrWhiteSpace(fileName))
			return null;

		// Upload the file.
		var assetFile = asset.AssetFiles.Create(fileName);
		assetFile.Upload(filePath);

		this.context.Locators.CreateLocator(LocatorType.Sas, asset, accessPolicy);

		// Done.
		return asset;
	}

	/// <summary>
	/// Uploads a file by creating an asset and a access policy.
	/// </summary>
	/// <param name="filePath">File path.</param>
	/// <param name="assetName">Name of the asset, give null to use filename.</param>
	/// <param name="asset">Asset to utilize.</param>
	/// <param name="accessPolicy">Access policy to utilize.</param>
	/// <param name="accessPolicyDuration">Length of access policy.</param>
	/// <param name="accessPolicyName">Name of the access policy to create.</param>
	/// <param name="assetCreationOptions">Options for asset creation.</param>
	/// <param name="assetNameOptions">Options for asset naming.</param>
	/// <returns>Created asset.</returns>
	public IAsset UploadFile(
		string filePath,
		string assetName,
		IAsset asset,
		IAccessPolicy accessPolicy,
		TimeSpan accessPolicyDuration,
		string accessPolicyName,
		AssetCreationOptions assetCreationOptions,
		AssetNameOptions assetNameOptions) {
		// Get filename from path.
		var fileName = Path.GetFileName(filePath);

		if (string.IsNullOrWhiteSpace(fileName))
			return null;

		// Create asset.
		if (assetName == null)
			assetName = (assetNameOptions == AssetNameOptions.KeepOriginalName
				? fileName
				: fileName.Replace(" ", "-") + "-" + DateTime.UtcNow.ToString(CultureInfo.InvariantCulture)
					.Replace(" ", "-")
					.Replace(":", "-")
					.Replace(".", "-"));

		if (asset == null)
			asset = this.context.Assets.Create(assetName, assetCreationOptions);

		// Create access policy.
		if (accessPolicy == null) {
			if (accessPolicyName == null)
				accessPolicyName = assetName;

			accessPolicy = this.context.AccessPolicies.Create(
				accessPolicyName,
				accessPolicyDuration,
				AccessPermissions.Write | AccessPermissions.List);
		}

		// Forward to common function.
		return this.UploadFile(filePath, asset, accessPolicy);
	}
}