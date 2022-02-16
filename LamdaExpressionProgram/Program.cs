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
            RetrievePersonAgeLessThan60(list);
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
        public static void RetrievePersonAgeLessThan60(List<Person> list)
        {
            List<Person> topTwoRecords = list.FindAll(p => p.Age < 60).OrderBy(a => a.Age).Take(2).ToList();
            IterateOverList(topTwoRecords);
        }
    }
}
