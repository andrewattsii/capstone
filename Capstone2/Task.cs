using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;

namespace Capstone2
{
    class Task
    {
        public List<string> members;
        public DateTime date;
        public string description;
        public bool status;
        //constructer
        public Task()
        {
            //instatuating member 
            members = new List<string>();
            status = false;
        }
        public static string CheckChar(string word)
        {
            if (Regex.IsMatch(word, @"([A-Z][a-z])*"))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Please enter a character ");
            }
            return word;
        }
        public static string CheckNumber()
        {
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^([1-5])"))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 5");
                return CheckNumber();
            }
            
        }
        public static DateTime GetDate()
        {
            string input = Console.ReadLine();
            if (DateTime.TryParse(input,out DateTime finalDate)) 
            {
                return finalDate;
            }
            else
            {
                Console.WriteLine("Please enter valid date");
                return GetDate();
            }
            

        }

    }
}
