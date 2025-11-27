namespace Service.Contracts
{
  public interface IBufferInfo
  {
    Task AddPhotoInfoToBuffer(Guid resumeId, CancellationToken token);
  }
}
