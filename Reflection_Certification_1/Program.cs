using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection_Certification_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person("Mukund","jahagirdar","abc",11);

            //p.GetPersonDetails();

            var person = Assembly.GetExecutingAssembly().GetType("Reflection_Certification_1.Person");

            

            object obj = Activator.CreateInstance(person, new object[] { "Mukund", "j", "abc", 5 });

            MethodInfo getpersondetailsmethod= person.GetMethod("GetPersonDetails");

            getpersondetailsmethod.Invoke(obj,null);



          

            
        }
    }

    public class Person
    {
        private string FirstName;
        private string LastName;
        private string address;
        private int age;

        public string SetFirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                
                
                    FirstName = value;
                
            }
        }
        public string SetLastName
        {
            get
            {
                return LastName;
            } 
            set
            {
                LastName = value;
            }
        }
        public string SetAddress
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public int Setage {  get
            {
                return age;
            }
            set
            {
                if (value > 10)
                {
                    age = value;
                }
                else
                {
                    age = -1;
                }
            }
        }

        public Person(string fname, string lname, string add, int age)
        {
            SetFirstName = fname;
            SetLastName = lname;
            SetAddress = add;
            Setage = age;
        }

        public void GetPersonDetails()
        {
            Console.WriteLine($"Hello this person name is {this.FirstName} , {this.LastName} and stays at {this.address} and is {this.age} years old");
        }

    }
}
