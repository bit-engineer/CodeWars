public class Kata
{
  public static string Greet(string name, string owner)
  {
    return name == owner ? "Hello boss" : "Hello guest";
  }  
}
