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

        public string Subject { get; set; }

        public List<string> Questions { get; set; }

        public List<string> Answers { get; set; }

        public MongoDBRef Professor { get; set; }
    }
}
