using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
     public class Person
    {
        public int Salary { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
        public string Address { get; set; }



      

        public void GetSalaryByFiltred()
        {
            var persons = GetAll();

           
            Console.WriteLine(persons.FindAll(m => m.Salary > 1000).Count);
        }

        internal void GetSalaryByFiltredy()
        {
            throw new NotImplementedException();
        }

        List<Person> GetAll()
        {
            List<Person> persons = new();

            Person person1 = new Person()
            {

                Name = "Aqsin",
                Surname = "Hummatov",
                Address = "Xirdalan",
                Salary= 1600,

            };

            Person person2 = new Person()
            {

                Name = "Samir",
                Surname = "Abbasov",
                Address = "Sumqayit",
                Salary = 1000,

            };

            Person person3 = new Person()
            {

                Name = "Elcan",
                Surname = "Ibrahimov",
                Address = "Bulbule",
                Salary = 1200,

            };

            Person person4 = new Person()
            {

                Name = "Rashad",
                Surname = "Islamov",
                Address = "Xirdalan",
                Salary = 2000,

            };



            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);
            persons.Add(person4);

            return persons;
           
        }


 
     }


}
