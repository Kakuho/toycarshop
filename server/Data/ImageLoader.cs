namespace VroomVroom.Data{
  public static class ImageLoader{
    public static string GetBytes(string filePath){
      byte[] bytes = System.IO.File.ReadAllBytes(filePath);
      System.Text.ASCIIEncoding encoder = new System.Text.ASCIIEncoding();
      return encoder.GetString(bytes);
    }
  }
}
