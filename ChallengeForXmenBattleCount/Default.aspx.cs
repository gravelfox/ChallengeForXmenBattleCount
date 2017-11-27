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
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";


            // Your Code Here!
            int maxFights = numbers[0];
            int minFights = numbers[0];

            for (int i = 1; i < names.Length; i++)
            {
                maxFights = (numbers[i] > maxFights) ? numbers[i] : maxFights;
                minFights = (numbers[i] < minFights) ? numbers[i] : minFights;
            }

            result = "Most battles belongs to: " + names[Array.IndexOf(numbers, maxFights)] + " (Value: " + maxFights + ")" + "<br />" +
                     "Least battles belongs to: " + names[Array.IndexOf(numbers, minFights)] + " (Value: " + minFights + ")";
            resultLabel.Text = result;
        }
    }
}