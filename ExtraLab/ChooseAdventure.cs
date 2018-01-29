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

            Console.WriteLine("Name: " + Name);
            

           
           
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
        
    }
}
