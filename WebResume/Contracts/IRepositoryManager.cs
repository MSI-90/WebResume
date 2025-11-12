namespace Contracts
{
  public interface IRepositoryManager
  {
    IResumeRepository Resume {  get; }
    ITemplateRepository Template { get; }
    ISpecialInfoRepository SpecialInfo { get; }
    void Save();
  }
}
