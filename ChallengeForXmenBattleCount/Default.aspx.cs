using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 12 };

            string result = "";


            // Your Code Here!
            int maxFights = numbers[0];
            int minFights = numbers[0];

            for (int i = 1; i < names.Length; i++)
            {
                maxFights = (numbers[i] > maxFights) ? numbers[i] : maxFights;
                minFights = (numbers[i] < minFights) ? numbers[i] : minFights;
            }

            //the below code handles ties for max and min fights.
            int minDupe = 0;
            int maxDupe = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                minDupe += (numbers[i] == minFights) ? 1 : 0;
                maxDupe += (numbers[i] == maxFights) ? 1 : 0;
            }

            if (minDupe == 1 && maxDupe == 1)
            {
                result = "Most battles belongs to: " + names[Array.IndexOf(numbers, maxFights)] + " (Value: " + maxFights + ")" + "<br />" +
                         "Least battles belongs to: " + names[Array.IndexOf(numbers, minFights)] + " (Value: " + minFights + ")";
            }
            else
            {
                if (maxDupe > 1)
                {
                    string maxNames = "";
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (numbers[i] == maxFights)
                        {
                            if (maxNames != "")
                            {
                                maxNames += ", ";
                            }
                            maxNames += names[i];
                        }
                    }
                    result = "Most battles is a tie between: " + maxNames + " (Value: " + maxFights + ")" + "<br />";
                }
                else
                {
                    result = "Most battles belongs to: " + names[Array.IndexOf(numbers, maxFights)] + " (Value: " + maxFights + ")" + "<br />";
                }
                if (minDupe > 1)
                {
                    string minNames = "";
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (numbers[i] == minFights)
                        {
                            if (minNames != "")
                            {
                                minNames += ", ";
                            }
                            minNames += names[i];
                        }
                    }
                    result += "Least battles is a tie between: " + minNames + " (Value: " + minFights + ")";
                }
                else
                {
                    result += "Most battles belongs to: " + names[Array.IndexOf(numbers, minFights)] + " (Value: " + minFights + ")";
                }
            }
            

           
            resultLabel.Text = result;

        }
    }
}