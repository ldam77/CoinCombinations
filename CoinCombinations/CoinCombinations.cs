using System;

namespace Coin
{
  public class CoinCombinations
  {
    private int Quarters = 0;
    private int Dimes = 0;
    private int Nickels = 0;
    private int Pennies = 0;

    public CoinCombinations()
    {

    }
    public int GetQuarters()
    {
      return Quarters;
    }
    public int GetDimes()
    {
      return Dimes;
    }
    public int GetNickels()
    {
      return Nickels;
    }
    public int GetPennies()
    {
      return Pennies;
    }

    // Recursive method of calculating
    public void CalculateCombinationsRecursive(int amount)
    {
      if(amount >= 25)
      {
        Quarters++;
        amount -= 25;
        CalculateCombinationsRecursive(amount);
      }
      else if(amount >= 10)
      {
        Dimes++;
        amount -= 10;
        CalculateCombinationsRecursive(amount);
      }
      else if(amount >= 5)
      {
        Nickels++;
        amount -= 5;
        CalculateCombinationsRecursive(amount);
      }
      else
      {
        Pennies += amount;
      }
    }

    // Non recursive method of calculating
    public void CalculateCombinations(int amount)
    {
      Quarters = amount / 25;
      int remainder = amount % 25;
      Dimes = remainder / 10;
      remainder = remainder % 10;
      Nickels = remainder / 5;
      Pennies = remainder % 5;
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter an amount:");
      int amount = int.Parse(Console.ReadLine());
      CoinCombinations coins = new CoinCombinations();
      coins.CalculateCombinationsRecursive(amount);
      Console.WriteLine("Quarters: " + coins.GetQuarters() + "  Dimes: " + coins.GetDimes() + "  Nickels: " + coins.GetNickels() + "  Pennies: " + coins.GetPennies());
      Console.WriteLine("Do you need to enter another amount? (Y/N)");
      string userInput = Console.ReadLine();
      if(userInput == "Y" || userInput == "y")
      {
        Main();
      }
    }
  }
}
