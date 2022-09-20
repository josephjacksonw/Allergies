using System;
using System.Collections.Generic;
namespace Allergens
{
  public class AllergyNum
  {
    public string showAllergies(int allergyNum)
    {
      List<string> outputList = new List<string> {};

      if (allergyNum >= 128)
      {
        allergyNum -= 128;
        outputList.Add("cats");
      }
      if (allergyNum >= 64)
      {
        allergyNum -= 64;
        outputList.Add("pollen");
      }
      if (allergyNum >= 32)
      {
        allergyNum -= 32;
        outputList.Add("chocolate");
      }
      if (allergyNum >= 16)
      {
        allergyNum -= 16;
        outputList.Add("tomatoes");
      }
      if (allergyNum >= 8)
      {
        allergyNum -= 8;
        outputList.Add("strawberries");
      }
      if (allergyNum >= 4)
      {
        allergyNum -= 4;
        outputList.Add("shellfish");
      }
      if (allergyNum >= 2)
      {
        allergyNum -= 2;
        outputList.Add("peanuts");
      }
      if (allergyNum >= 1)
      {
        allergyNum -= 1;
        outputList.Add("eggs");
      }

      string outputString = "";
      for (int i=0; i < outputList.Count; i++) {
        //outputString.Concat(outputList[i]);
        outputString += outputList[i];
        if (i != outputList.Count - 1)
        {
          outputString += ", ";
        }
      }
      return outputString;
    }
  }
}
