using System.ComponentModel.DataAnnotations;

namespace artistapi.Models{
  public class Art{
    public int Id { get; set; }
    [Required]
    public string Title { get ; set; }
    public string Description {get; set;}

    public string ImgUrl {get ; set; }
  }
}