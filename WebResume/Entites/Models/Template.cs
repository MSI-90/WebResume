using Entites.Enums;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entites.Models
{
  public class Template
  {
    [Column("template_id")]
    public Guid TemplateId { get; set; }
    public string? Name { get; set; }
    public TemplateKind TemplateKind { get; set; }

    public ICollection<Resume>? ResumeList { get; set; }
  } 
}
