using BackendAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendAPI.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAllPersons( string query, int page, int pageSize);
        int GetAge(string query);
        string GetEmail(string query);
        string GetFirstName(string query);
        string GetLastName(string query);
    }
}
