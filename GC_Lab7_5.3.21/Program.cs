using System;
using System.Text.RegularExpressions;

namespace GC_Lab7_5._3._21
{
    class Program
    {
        
        static void Main(string[] args)
        {

            string name = PromptMessage("What is your name?");
            ValidateNames(name);

            string email = PromptMessage("What is your email?");
            ValidateEmail(email);

            string phone = PromptMessage("What is your phone number?");
            ValidatePhone(phone);

            string date = PromptMessage("What is your birthday?");
            ValidateDate(date);
        }

       
        static public string PromptMessage(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        // 1. Method that will validate names. Names can only have alphabets, start with a capital, max length of 30
        //^[A-Z][a-z]{1,29}$ -- start with 1 uppercase, 1-29 other alphabet characters for a max of 30

        static public string ValidateNames(string name)
        {
            string nameRegex = "^[A-Z][a-z]{1,29}$";

            if (Regex.IsMatch(name, nameRegex))
            {
                Console.WriteLine("Name is valid!"); 
            } else
            {
                Console.WriteLine("Sorry, that is not a valid name! Please start with a captial letter and use letters only.");
            }
            return name;

        }

        // 2. Method that will validate emails {alphanumerica between 5 and 30, no special characters}@{alphanumberic between 5 and 10}.{doman 3 alphanumber 2 or 3}
        // ^([A-Za-z0-9]){5,30}@([A-Za-z0-9]){5,10}\.([A-Za-z0-9]){2,3}$

        static public string ValidateEmail(string email)
        {
            string nameRegex = @"^([A-Za-z0-9]){5,30}@([A-Za-z0-9]){5,10}\.([A-Za-z0-9]){2,3}$";

            if (Regex.IsMatch(email, nameRegex))
            {
                Console.WriteLine("Email is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, that is not a valid email!");
            }
            return email;

        }

        // 3. Write a method that will validate phone numbers {area code 3 digits}-{3digits}-{4digits}
        //^[0-9]{3}-[0-9]{3}-[0-9]{4}$

        static public string ValidatePhone(string phone)
        {
            string nameRegex = "^[0-9]{3}-[0-9]{3}-[0-9]{4}$";

            if (Regex.IsMatch(phone, nameRegex))
            {
                Console.WriteLine("Phone number is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, that is not a valid phone number format! Use format XXX-XXX-XXXX");
            }
            return phone;

        }

        // 4. validat date: (dd/mm/yyyy)
        //^(0[1-9]|1[0-2])\/(0[1-9]|(1|2)[0-9]|3[0-1])\/\d{4}$

        static public string ValidateDate(string date)
        {
            string nameRegex = @"^(0[1-9]|1[0-2])\/(0[1-9]|(1|2)[0-9]|3[0-1])\/\d{4}$";
            
            if (Regex.IsMatch(date, nameRegex))
            {
                Console.WriteLine("Date is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, that is not a valid date format! Use format MM/DD/YYYY");
            }
            return date;

        }
    }
}
