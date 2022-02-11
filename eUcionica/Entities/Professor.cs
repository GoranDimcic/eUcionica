﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcionica.Entities
{
    public class Professor
    {   
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Subject { get; set; }

        //public List<MongoDBRef> Subjects { get; set; }


    }
}
