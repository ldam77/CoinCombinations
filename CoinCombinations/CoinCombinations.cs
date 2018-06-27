using System;

namespace Coin
{
  public class CoinCombinations
  {
    private int Quarters;
    private int Dimes;
    private int Nickels;
    private int Pennies;

    public CoinCombinations()
    {
      Quarters = 0;
      Dimes = 0;
      Nickels = 0;
      Pennies = 0;
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

    public void CalculateCombinations(int amount)
    {
      if(amount >= 25)
      {
        Quarters++;
        amount -= 25;
        CalculateCombinations(amount);
      }
      else if(amount >= 10)
      {
        Dimes++;
        amount -= 10;
        CalculateCombinations(amount);
      }
      else if(amount >= 5)
      {
        Nickels++;
        amount -= 5;
        CalculateCombinations(amount);
      }
      else{
        Pennies += amount;
      }
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter an amount:");
      int amount = int.Parse(Console.ReadLine());
      CoinCombinations coins = new CoinCombinations();
      coins.CalculateCombinations(amount);
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
