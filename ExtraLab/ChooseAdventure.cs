using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtraLab
{
    class Program
    {
        static bool RunApplication = true;

        static void Main(string[] args)
        {     
            Console.WriteLine("Choose Your Own Adventure: Forest"); //TODO: Outer Space, Cave, Mountains, Ocean, City
            
            string Name = ReadUserInput("\nEnter your name.");
            Console.Clear();
            string FirstSkill = FirstSkills($"Pick a skill {Name}!\n[1] Archery\t[2] Baking");
            
            Console.WriteLine("You chose: " + FirstSkill);            
           
        }
        public static string ReadUserInput(string UserPrompt)
        {
            Console.WriteLine(UserPrompt);
            string Name = Console.ReadLine().Trim();
            var InputRegex = new Regex(@"^\w+( \w+)*$");
            if (InputRegex.IsMatch(Name))
            {
                return Name;
            }                      
            return ReadUserInput(UserPrompt);
        }   

        public static string FirstSkills (string SkillChoice1)
        {
            Console.WriteLine(SkillChoice1);
            string Choice = Console.ReadLine().Trim();

            var Archery = new Regex(@"^[1]$");
            var Baking = new Regex(@"^[2]$");
            

            if (Archery.IsMatch(Choice))
            {
                Console.WriteLine("Archery!");
                return Choice;
            }
            else if (Baking.IsMatch(Choice))
            {
                Console.WriteLine("Baking!");
                return Choice;
            }
            Console.Clear();
            return FirstSkills(SkillChoice1);
        }

        public static string SecondSkills (string SkillChoice2)
        {
            Console.WriteLine(SkillChoice2);
            string Choice = Console.ReadLine().Trim();

            var MakingJewlery = new Regex(@"^[3]$");
            var Poetry = new Regex(@"^[4]$");

            if (MakingJewlery.IsMatch(Choice))
            {
                Console.WriteLine("Making jewlery!");
                return Choice;
            }
            else if (Poetry.IsMatch(Choice))
            {
                Console.WriteLine("Poetry!");
                return Choice;
            }
            Console.Clear();
            return SecondSkills(SkillChoice2);
        }       
    }
}
