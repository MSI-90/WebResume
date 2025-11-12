namespace Service.Contracts
{
  public interface IServiceManager
  {
    IResumeService ResumeService { get; }
    ITemplateService TemplateService { get; }
    ISpecialInfoService SpecialInfoService { get; }
  }
}
