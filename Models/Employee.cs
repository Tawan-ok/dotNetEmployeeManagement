using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }  

        [BsonElement("name")]
        public string? Name { get; set; }  

        [BsonElement("email")]
        public string? Email { get; set; }  
        [BsonElement("position")]
        public string? Position { get; set; } 

        [BsonElement("salary")]
        public decimal Salary { get; set; }
    }
}
