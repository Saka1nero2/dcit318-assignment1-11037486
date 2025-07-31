

class Grade
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Enter your grade (0-100) ");
    string? input = Console.ReadLine();

    //Console.WriteLine("Your grade : " + studentGrade);

    if (int.TryParse(input, out int studentGrade))
    {
      if (studentGrade < 0 || studentGrade > 100)
      {
        Console.WriteLine("Invalid grade. Please enter a grade between 0 and 100");
      }
      else if (studentGrade >= 90)
      {
        Console.WriteLine("You got an A !");
      }
      else if (studentGrade >= 80)
      {
        Console.WriteLine("You got a B !");
      }
      else if (studentGrade >= 70)
      {
        Console.WriteLine("You got a c !");
      }
      else if (studentGrade >= 60)
      {
        Console.WriteLine("You got a D!");
      }
      else
      {
        Console.WriteLine("You got an F!");
      }
    }
    else
    {
      Console.WriteLine("Invalid input. Please enter a numeric value.");
    }
  }
}



