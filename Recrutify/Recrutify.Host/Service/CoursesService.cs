using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using Recrutify.DataAccess;
using Recrutify.Host.Configuration;

namespace Recrutify.Host.Service
{
    public class CoursesService
    {
        private readonly IMongoCollection<Course> _collection;

        public CoursesService(IMongoSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _collection = database.GetCollection<Course>("Course");
        }

        public Course Creat(Course course)
        {
            _collection.InsertOne(course);
            return course;
        }

        public List<Course> Read() =>
            _collection.Find(course => true).ToList();
    }
}
