using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcionica.Entities
{
    public class Test
    {
        public ObjectId Id { get; set; }

        public String Questions { get; set; }

        public String Answers { get; set; }

        public DateTime Date { get; set; }

        public MongoDBRef Professor { get; set; }

        public List<MongoDBRef> Students { get; set; }

        public Test()
        {
            Students = new List<MongoDBRef>();
        }
    }
}
