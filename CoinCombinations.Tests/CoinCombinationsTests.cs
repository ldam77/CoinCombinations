using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombinations;

namespace Coin.Tests
{
  [TestClass]
  public class CoinCombinationsTest
  {
    [TestMethod]
    public void CalculateCombinations_GetNumberOfCoins()
    {
      //Arrange
      int amount = 50;
      CoinCombinations coins = new CoinCombinations();
      int quarters = 2;

      //Act
      coins.CalculateCombinations(amount);
      int quartersCount = coins.GetQuarters();

      //Assert
      Assert.AreEqual(quarters, quartersCount);
    }
  }
}
