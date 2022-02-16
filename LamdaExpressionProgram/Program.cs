using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressionProgram
{
    public class Program
    {
        /// <summary>
        /// Person Data Management Using Lambda Expression
        /// </summary>
        public static void Main(string[] args)
        {
            //Displaying the message
            Console.WriteLine("Welcome To The Person Data Management Using Lambda Expression Program");
            
            //Creating the list object(UC1)
            List<Person> list = new List<Person>();
            
            //Calling the method to add default values to the list(UC1)
            Console.WriteLine("\nPerson Details Are Listed Below");
            AddPersonDetailsIntoList(list);
            
            //Calling the method to retrieve top two records whose age is less than sixty(UC2)
            Console.WriteLine("Top Two Records Whos Age Is Less Than 60");
            RetrievePersonAgeLessThanSixty(list);
            
            //Calling the method to retrieve Retrieve all record from the list for age between 13 to 18 (UC3)
            Console.WriteLine("Teenage Records Whos Age Is Between 13 & 18");
            RetrieveAllTeenageRecords(list);
            
            //Calling the method to retrieve average age in the list(UC4)
            RetrieveAverageAgeRecords(list);
            
            //Calling the method to check the given person name in the list(UC5)
            Console.Write("Enter The Name Of The Person : ");
            SearchPersonName(list, Console.ReadLine());

            //Calling method to skip a record from the list for age is less than 60(UC6)
            Console.WriteLine("Skipping A Record Whos Age Is Less Than 60");
            SkipAgeLessThanSixty(list);
            Console.ReadLine();
        }

        //Method to add the default values to create list
        public static void AddPersonDetailsIntoList(List<Person> list)
        {
            list.Add(new Person() { Address = "Mumbai", Age = 15, Name = "Raj", SSN = 1 });
            list.Add(new Person() { Address = "Delhi", Age = 14, Name = "Yash", SSN = 2 });
            list.Add(new Person() { Address = "Mumbai", Age = 32, Name = "Ajay", SSN = 3 });
            list.Add(new Person() { Address = "Mumbai", Age = 65, Name = "Raj", SSN = 4 });
            list.Add(new Person() { Address = "Faridabad", Age = 70, Name = "Mansi", SSN = 5 });
            list.Add(new Person() { Address = "Bhopal", Age = 62, Name = "Nidhi", SSN = 6 });
            list.Add(new Person() { Address = "Kerala", Age = 17, Name = "Aman", SSN = 7 });
            IterateOverList(list);
        }

        //Method to iterate over the list(UC1)
        public static void IterateOverList(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
        }

        //Method to retrieve top two records whose age is less than sixty(UC2)
        public static void RetrievePersonAgeLessThanSixty(List<Person> list)
        {
            List<Person> topTwoRecords = list.FindAll(p => p.Age < 60).OrderBy(a => a.Age).Take(2).ToList();
            IterateOverList(topTwoRecords);
        }

        //Method to retrieve Retrieve all record from the list for age between 13 to 18 (UC3)
        public static void RetrieveAllTeenageRecords(List<Person> list)
        {
            List<Person> teenageRecords = list.FindAll(p => p.Age >= 13 && p.Age <= 18);
            IterateOverList(teenageRecords);
        }

        //Method to retrieve average age in the list(UC4)
        public static void RetrieveAverageAgeRecords(List<Person> list)
        {
            double averageAge = list.Average<Person>(p => p.Age);
            Console.WriteLine("Average Age In Person Records Are : {0}", Math.Round(averageAge, 2));
            Console.ReadLine();
        }

        //Method to check the given person name in the list(UC5)
        public static void SearchPersonName(List<Person> list, string name)
        {
            var personRes = list.FindAll(p => p.Name.Equals(name));
            if (personRes.Count() != 0)
            {
                Console.WriteLine("The Given Person {0} Is Present In The List", name);
                IterateOverList(personRes);
            }    
            else
                Console.WriteLine("The Given Person {0} Is Not Present In The List", name);
        }

        //Method to skip a record from the list for age is less than 60(UC6)
        public static void SkipAgeLessThanSixty(List<Person> list)
        {
            List<Person> greaterAge = list.FindAll(p => p.Age < 60).Skip(1).ToList();
            IterateOverList(greaterAge);
        }
    }
}
