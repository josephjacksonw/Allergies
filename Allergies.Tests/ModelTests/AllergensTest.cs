using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergens;

namespace Allergens.Tests
{
  [TestClass]
  public class AllergenTests
  {
    [TestMethod]
    public void showAllergies_revealAllergens_Array()
    {
      AllergyNum testVar = new AllergyNum();
      Assert.AreEqual("cats, pollen, chocolate, tomatoes, strawberries, shellfish, peanuts, eggs", testVar.showAllergies(255));
    }
  }
}