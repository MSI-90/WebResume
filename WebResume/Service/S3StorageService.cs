using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.S3;
using Amazon.S3.Model;
using Entites.Exceptions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Linq;

namespace Service
{
  public sealed class S3StorageService : IS3StorageService
  {
    private readonly ILogger<S3StorageService> _logger;
    private readonly RegRuS3Dto _regRuConfiguration;
    private readonly AmazonS3Client _amazonS3client;
    public S3StorageService(IOptions<RegRuS3Dto> regRu, ILogger<S3StorageService> logger)
    {
      _logger = logger;
      _regRuConfiguration = regRu.Value;
      _amazonS3client = new AmazonS3Client(_regRuConfiguration.AccessKey, _regRuConfiguration.SecretAccessKey,
        new AmazonS3Config
        {
          ServiceURL = _regRuConfiguration.EndpointURL,
          ForcePathStyle = true
        });
    }

    public async Task<bool> CheckBucketAsync()
    {
      var responseFromS3 = await _amazonS3client.ListBucketsAsync();
      if (responseFromS3 == null || responseFromS3.Buckets == null)
        return false;

      return responseFromS3.Buckets.Any(b => b.BucketName.Equals(_regRuConfiguration.BucketName, StringComparison.OrdinalIgnoreCase));
    }

    public async Task<(bool, string?, string?)> UploadFileAsync(FileDto? file)
    {
      if (!await CheckBucketAsync())
        throw new BucketUndefinedException();

      var newFileName = Guid.NewGuid().ToString();
      try
      {
        var request = new PutObjectRequest
        {
          BucketName = _regRuConfiguration.BucketName,
          Key = newFileName,
          InputStream = file?.FileStream,
        };

        await _amazonS3client.PutObjectAsync(request);
        _logger.LogInformation($"Successfully uploaded {request.Key} to {_regRuConfiguration.BucketName}."); 
        return (true, newFileName, GeneratePresignedURL(request.Key, 1));
      }
      catch (AmazonS3Exception ex)
      {
        _logger.LogError($"Could not upload file to {_regRuConfiguration.BucketName}: '{ex.Message}'");
        return (false, null, null);
      }
    }

    public string GeneratePresignedURL(string objectKey, double duration)
    {
      string urlString = string.Empty;
      try
      {
        var request = new GetPreSignedUrlRequest()
        {
          BucketName = _regRuConfiguration.BucketName,
          Key = objectKey,
          Expires = DateTime.UtcNow.AddHours(duration),
        };
        urlString = _amazonS3client.GetPreSignedURL(request);
      }
      catch (AmazonS3Exception ex)
      {
        _logger.LogError($"Error:'{ex.Message}'");
      }

      return urlString;
    }

    ~S3StorageService(){
      _amazonS3client.Dispose();
    }
  }
}
