using MongoDB.Driver;
using EmployeeManagement.Models;
namespace EmployeeManagement.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase("EmployeeDB");
        }

        public IMongoCollection<Employee> Employees => _database.GetCollection<Employee>("Employees");
    }
}
