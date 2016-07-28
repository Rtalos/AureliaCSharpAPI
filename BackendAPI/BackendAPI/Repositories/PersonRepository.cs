using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using BackendAPI.Entities;

namespace BackendAPI.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public int GetAge(string query)
        {
            if (query == "First")
            {
                return 5;
            }
            else
                return 0;
        }

        public IEnumerable<Person> GetAllPersons(string query, int page, int pageSize)
        {
            return new List<Person>
            {
                new Person {  Age = 25, Email = "abc@hotmail.com", FirstName = "Nikolaus", LastName = "Krautz" },

                new Person { Age = 30, Email = "def@hotmail.com", FirstName = "Martin", LastName = "Schleiss" },

                new Person { Age = 25, Email = "ghi@hotmail.com", FirstName = "Peter", LastName = "Strauss" },

                new Person { Age = 25,  Email = "jkl@hotmail.com", FirstName = "Viktor", LastName = "Oberhauser" },

                new Person { Age = 25, Email = "mno@hotmail.com", FirstName = "Klaus", LastName = "Nietzmann" },
            };
        }

        public string GetEmail(string query)
        {
            return "abc@hotmail.com";
        }

        public string GetFirstName(string query)
        {
            return "Nikolaus";
        }

        public string GetLastName(string query)
        {
            return "Krautz";
        }
    }
}
