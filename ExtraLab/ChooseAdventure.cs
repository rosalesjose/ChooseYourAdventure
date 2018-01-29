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
        static bool ChooseSkills = true;
        static bool RunProgram = true;
        static void Main(string[] args)
        {
            Console.Title = "Choose Your Own Adventure: Forest Breeze"; //TODO: Outer space, Cave, Mountains, Ocean, City

            string Name = ReadUserInput("What's your name?");
            Console.Clear();
            while (ChooseSkills)
            {
                string FirstSkill = FirstSkills($"Pick a skill {Name}!\n[1] Archery\t[2] Baking");
                Console.Clear();
                string SecondSkill = SecondSkills("It's pretty dangerous out there. Pick another skill.\n" +
                                                  "[3] Making jewlery\t[4] Poetry");
                Console.Clear();
                Console.WriteLine("You chose {0} and {1}!\nAlright, {2} do you want to continue " +
                                  "or choose different skills?", FirstSkill, SecondSkill, Name);

                Console.WriteLine("\n[Y] Yes, continue.\t[N] Wait, I want to change my skills.");
                bool UserDecision = Decision(char.Parse(Console.ReadLine()));
            }
            Console.Clear();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("\nIt was a perfectly normal day...");
            

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

        public static string FirstSkills(string SkillChoice1)
        {
            Console.WriteLine(SkillChoice1);
            string Choice = Console.ReadLine().Trim();

            var Archery = new Regex(@"^[1]$");
            var Baking = new Regex(@"^[2]$");


            if (Archery.IsMatch(Choice))
            {
                Console.WriteLine("Archery!");
                Choice = "archery";
                return Choice;
            }
            else if (Baking.IsMatch(Choice))
            {
                Console.WriteLine("Baking!");
                Choice = "baking";
                return Choice;
            }
            Console.Clear();
            return FirstSkills(SkillChoice1);
        }

        public static string SecondSkills(string SkillChoice2)
        {
            Console.WriteLine(SkillChoice2);
            string Choice = Console.ReadLine().Trim();

            var MakingJewlery = new Regex(@"^[3]$");
            var Poetry = new Regex(@"^[4]$");

            if (MakingJewlery.IsMatch(Choice))
            {
                Console.WriteLine("Making jewlery!");
                Choice = "making jewlery";
                return Choice;
            }
            else if (Poetry.IsMatch(Choice))
            {
                Console.WriteLine("Poetry!");
                Choice = "poetry";
                return Choice;
            }
            Console.Clear();
            return SecondSkills(SkillChoice2);
        }

        public static bool Decision(char UserDecision)
        {
            if (UserDecision == 'n' || UserDecision == 'N')
            {
                Console.Clear();
                return ChooseSkills = true;
            }
            else if (UserDecision == 'y' || UserDecision == 'Y')
            {
                return ChooseSkills = false;
            }
            return Decision(UserDecision);
        }
    }
}
