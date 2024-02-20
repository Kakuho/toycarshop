namespace VroomVroom.Models{
  public class Car{
    public long Id {get; set;}
    public string? Name{get; set;}
    public string? Description{get; set;}
    public string? Image{get; set;}
    public Category Category{get; set;}
    public decimal Price{get; set;}
  }

  public enum Category{
    Basic,
    Fruit,
    Metal,
    Special,
    GreekGod,
    NA
  };
}
