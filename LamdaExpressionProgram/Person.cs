using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressionProgram
{
    /// <summary>
    /// Created The Person Class With SSN, Name, Address, Age(UC1)
    /// </summary>
    public class Person
    {
        //Declaring the properties(UC1)
        public int SSN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }


        //Overiding the string method (UC1)
        public override string ToString()
        {
            return $"Person SSN : {SSN} \tName : {Name} \tAddress : {Address} \tAge : {Age}";
        }
    }
}
