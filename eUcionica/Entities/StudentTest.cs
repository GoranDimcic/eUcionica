using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcionica.Entities
{
    public class StudentTest
    {
        public ObjectId Id { get; set; }

        public MongoDBRef Test { get; set; }

        public MongoDBRef Student { get; set; }

        public String StudentAnswers { get; set; }

        public int Grade { get; set; }
    }
}
