using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethidOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel("brice", "donny");
            person.GenerateEmail(true);
            Console.WriteLine(person.Email);
            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public PersonModel()
        {
            
        }

        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public PersonModel(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void GenerateEmail()
        {
            GenerateEmail("gmail.net", false);
        }

        public void GenerateEmail(string domain)
        {
            GenerateEmail(domain, false);
        }

        public void GenerateEmail(bool firstInitialMethod)
        {
            GenerateEmail("gmail.net", firstInitialMethod);
        }

        public void GenerateEmail(string domain, bool firstInitialMethod)
        {
            if (firstInitialMethod == true)
            {
                Email = $"{FirstName.Substring(0, 1)}_{LastName}@{domain}";
            }
            else
            {
                Email = $"{FirstName}-{LastName}@{domain}.com";
            }
        }

    }

}
