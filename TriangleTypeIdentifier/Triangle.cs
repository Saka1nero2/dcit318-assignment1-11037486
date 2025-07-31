class Triangle
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Enter  the sides a,b,c");
    string? length1 = Console.ReadLine();
    string? length2 = Console.ReadLine();
    string? length3 = Console.ReadLine();

    if (int.TryParse(length1, out int side1) &&
    int.TryParse(length2, out int side2) &&
    int.TryParse(length3, out int side3)
    )
    {
      if (side1 == side2 && side2 == side3)
      {
        Console.WriteLine("This is an E quilateral triangle");
      }
      else if (side1 == side2 || side1 == side3 || side2 == side3)
      {
        Console.WriteLine("This is an isoceles triangle");
      }
      else
      {
        Console.WriteLine("This is a Scalene Triangle");
      }
    }
    else
    {
      Console.WriteLine("Invalid input. Please enter valid numbers for all sides.");
    }
  }
}