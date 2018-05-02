using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {        
        static void Main(string[] args)

        {
            // set up database
            // ask about index
            //ask about hometown and favorite food with if/else if/ else
            //>> else is the validation for incorrect input
            // print user info

            string[] Names = { "Amy","Kim","Tyler","Rachel","Andy","Sarah","John",
                "Kevin", "Ken", "Matthew"};
            string[] FavoriteFoods ={ "pizza","grapes","fries","mashed ptatos","green beens",
                "fried chicken","ribs","candy","hot pocket", "chicken nuggets","cheese"};
            string[] HomeTown = { "Detroit", "Ann Arbor", "Saline", "Boston", "Chicago", "NewYork", "phoenix", "orlando", "seattle", "dallas" };
            int NameId;

            while (true)
            {
                Console.WriteLine("which student would you like to learn more about(use number 1-10)?");
                NameId = int.Parse(Console.ReadLine());
                Console.WriteLine($"{Names[NameId]}");

                Console.WriteLine($"would you like to learn about {Names[NameId]}'s Favorite Food or Hometown: Food/Home");
                string response = Console.ReadLine().ToLower();
                
                if (response == "food")
                {
                    Console.WriteLine($"{Names[NameId]}'s Favorite Food is {FavoriteFoods[NameId]}");
                }
                else if (response == "home")
                {
                    Console.WriteLine($"{Names[NameId]}'s Home Town is {HomeTown[NameId]}");
                }
                else
                {
                    break;
                }
                Console.WriteLine("would you like to learn about a different student: y/n");
                string MoreInfo = Console.ReadLine().ToLower();
                if (MoreInfo == "n")
                {
                    break;
                }

            }

        }                    
    }
}
