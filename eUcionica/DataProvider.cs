﻿using eUcionica.Entities;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUcionica
{
    public class DataProvider
    {
        public void AddProfessor(string name, string email, string password, string subject)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");

            var collection = db.GetCollection<Professor>("professors");

            Professor professor = new Professor
            {
                Name = name,
                Email = email,
                Password = password,
                Subject = subject
            };

            collection.Insert(professor);
        }

        public Professor GetProfessor(string email, string password)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");

            var professorCollection = db.GetCollection("professors");

            var query = (from Professor in professorCollection.AsQueryable<Professor>()
                         where Professor.Email == email && Professor.Password == password
                         select Professor).FirstOrDefault();

            return query;
        }

        public void AddStudent(string email, string password, string name)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");

            var collection = db.GetCollection<Student>("students");

            Student student = new Student
            {
                Name = name,
                Email = email,
                Password = password
            };

            collection.Insert(student);
        }

        public Student GetStudent(string email, string password)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");

            var studentCollection = db.GetCollection("students");

            var query = (from Student in studentCollection.AsQueryable<Student>()
                         where Student.Email == email && Student.Password == password
                         select Student).FirstOrDefault();

            return query;
        }

        public void AddTest(String questions, String answers, DateTime date, Professor professor)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");
            MongoDBRef m = new MongoDBRef("professors", professor.Id);

            var collection = db.GetCollection<Test>("tests");

            Test test = new Test
            {
                Date = date,
                Professor = m,
                Questions = questions,
                Answers = answers
            };

            collection.Insert(test);

            var vcollection = db.GetCollection<Professor>("professors");

            professor.Tests.Add(new MongoDBRef("tests", test.Id));

            vcollection.Save(professor);
        }
    }
}
