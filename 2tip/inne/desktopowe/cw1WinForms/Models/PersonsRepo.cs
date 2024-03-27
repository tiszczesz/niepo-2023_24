using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw1WinForms.Models
{
    public class PersonsRepo
    {
        public List<Person>? Persons { get; set; }
        private string _filename = "Data.txt";
        public PersonsRepo()
        {
            Persons = LoadFromFile(_filename);
        }

        private List<Person>? LoadFromFile(string filename)
        {
            var lines = File.ReadAllLines(_filename);
            List<Person> persons = new List<Person>();
            foreach (var line in lines)
            {
                var splitted = line.Split('|');
                if (splitted.Length == 4)
                {
                    persons.Add(new Person
                    {
                        Id = Convert.ToInt32(splitted[0]),
                        Firstname = splitted[1],
                        Lastname = splitted[2],
                        Age = Convert.ToInt32(splitted[3])
                    });
                }
            }
            return persons;
        }
    }
}
