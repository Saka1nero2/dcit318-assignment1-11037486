class TicketPriceCalculator
{
  public static void Main(string[] args)
  {

    const int fullPrice = 10;
    const int discountedPrice = 7;

    Console.WriteLine("Enter your age");
    string? input = Console.ReadLine();

    if (int.TryParse(input, out int personAge))
    {

      int finalPrice;

      if (personAge >= 65 || personAge <= 12)
      {
        finalPrice = discountedPrice;
        Console.WriteLine($"You qualify for a discount. Ticket price : GHC{finalPrice}");
      }
      else
      {
        finalPrice = fullPrice;
        Console.WriteLine($"Standard ticket price: GHC{finalPrice}");
      }
    }
    else
    {
      Console.WriteLine("Invalid input.Please enter a valid number.");
    }

  }
}