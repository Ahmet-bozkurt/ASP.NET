using MongoDemoData.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDemoData.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IDataAccess _db;
        public PersonRepository(IDataAccess db)
        {
            _db = db;
        }
        public async Task<bool> AddPerson(Person person)
        {
            try
            {
                String query = "insert into dbo.person(name,email) values(@Name,@Email)";
                await _db.SaveData(query, new { Name = person.Name, Email = person.Email });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeletePerson(int id)
        {
            try
            {
                String query = "delete from dbo.person where id=@Id";
                await _db.SaveData(query, new {Id = id});
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Person>> GetAllPersons()
        {
            string query = "select * from dbo.person";
            var persons = await _db.GetData<Person, dynamic>(query, new {});
            return persons;
        }

        public async Task<Person> GetPersonById(int id)
        {
            string query = "select * from dbo.person where id=@Id";
            IEnumerable<Person> person = await _db.GetData<Person, dynamic>(query, new {Id=id });
            return person.FirstOrDefault();
        }

        public async Task<bool> UpdatePerson(Person person)
        {
            try
            {
                String query = "update dbo.person set name=@Name, email=@Email where id=@Id";
                await _db.SaveData(query, person);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
