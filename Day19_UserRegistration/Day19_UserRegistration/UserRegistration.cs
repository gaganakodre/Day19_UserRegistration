﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_UserRegistration
{
    public class RegexClass
    {
        public Regex FirstNameRegex = new Regex(@"^[A-Z]{1}[A-Za-z]{3,}?$");
        public void ValidateFirstNameRegex(string FirstName)
        {
            Console.WriteLine("\nFirstName:" + FirstName);
            if(FirstNameRegex.IsMatch(FirstName))
            {
                Console.WriteLine("valide");
            }
            else
            {
                Console.WriteLine("not valid");
            }
            
        }
        public Regex LastNameRegex = new Regex(@"^[A-Z]{1}[A-Za-z]{3,}?$");
        public void ValidateLastNameRegex(string LastName)
        {
            Console.WriteLine("\nLastName:" + LastName);
            if (LastNameRegex.IsMatch(LastName))
            {
                Console.WriteLine("valide");
            }
            else
            {
                Console.WriteLine("not valid");
            }


        }



    }
}
