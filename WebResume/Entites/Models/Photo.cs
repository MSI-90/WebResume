using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  [Table("photo")]
  public class Photo
  {
    [Column("id")]
    public Guid? Id { get; set; }

    [Column("file_name")]
    public string? FileName { get; set; }

    [Column("length")]
    public long Length { get; set; }

    public Resume? Resume { get; set; } 
  }
}
