using eUcionica.Entities;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
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

        public Student GetStudent(string name)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");

            var studentCollection = db.GetCollection("students");

            var query = (from Student in studentCollection.AsQueryable<Student>()
                         where Student.Name == name
                         select Student).FirstOrDefault();

            return query;
        }

        public void AddTest(String questions, String answers, DateTime date, string name, Professor professor)
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
                Answers = answers,
                Name = name
            };

            collection.Insert(test);

            var vcollection = db.GetCollection<Professor>("professors");

            professor.Tests.Add(new MongoDBRef("tests", test.Id));

            vcollection.Save(professor);
        }

        public Professor GetProfessor(string subject)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");

            var professorCollection = db.GetCollection("professors");

            var query = (from Professor in professorCollection.AsQueryable<Professor>()
                         where Professor.Subject == subject
                         select Professor).FirstOrDefault();

            return query;
        }

        public List<Test> GetTests(String subject)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");

            var professorCollection = db.GetCollection("professors");
            var testCollection = db.GetCollection("tests");

            Professor m = GetProfessor(subject);

            MongoDBRef m1 = new MongoDBRef("professors", m.Id);
            List<Test> lista = new List<Test>();
            var query = from Test in testCollection.AsQueryable<Test>()
                        where Test.Professor == m1
                        select Test;

            foreach (Test test in query)
            {
                lista.Add(test);
            }

            return lista;
        }

        public List<Test> GetTests(Professor professor)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");

            var professorCollection = db.GetCollection("professors");
            var testCollection = db.GetCollection("tests");

            //Professor m = GetProfessor(subject);

            MongoDBRef m1 = new MongoDBRef("professors", professor.Id);
            List<Test> lista = new List<Test>();
            var query = from Test in testCollection.AsQueryable<Test>()
                        where Test.Professor == m1
                        select Test;

            foreach (Test test in query)
            {
                lista.Add(test);
            }

            return lista;
        }

        public List<Student> GetStudents(Test test)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");

            var studentsCollection = db.GetCollection("students");
            var testCollection = db.GetCollection("tests");

            //Professor m = GetProfessor(subject);

            MongoDBRef m1 = new MongoDBRef("tests", test.Id);
            List<Student> lista = new List<Student>();
            var query = from Student in studentsCollection.AsQueryable<Student>()
                        where Student.Tests.Contains(m1)
                        select Student;

            foreach (Student student in query)
            {
                lista.Add(student);
            }

            return lista;
        }

        public Test GetTest(string name)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");

            var testCollection = db.GetCollection("tests");

            var query1 = (from test in testCollection.AsQueryable<Test>()
                          where test.Name == name
                          select test).FirstOrDefault();

            return query1;
        }

        public String GetQuestions(string name)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");

            var testCollection = db.GetCollection("tests");

            var query = (from test in testCollection.AsQueryable<Test>()
                         where test.Name == name
                         select test.Questions).FirstOrDefault();

            return query;
        }

        public String GetAnswers(string name)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");

            var testCollection = db.GetCollection("tests");

            var query = (from test in testCollection.AsQueryable<Test>()
                         where test.Name == name
                         select test.Answers).FirstOrDefault();

            return query;
        }

        public String GetResults(string name, string studentName)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");

            var studenttestCollection = db.GetCollection("studenttest");
            Test t = GetTest(name);
            MongoDBRef test = new MongoDBRef("tests", t.Id);

            Student s = GetStudent(studentName);
            MongoDBRef student = new MongoDBRef("students", s.Id);

            var query = (from st in studenttestCollection.AsQueryable<StudentTest>()
                         where st.Test == test || st.Student == student
                         select st.StudentAnswers).FirstOrDefault();

            return query;
        }

        public void AddStudentTest(Student student, Test test, string answers)
        {
            DataProvider data = new DataProvider();
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");
            MongoDBRef t = new MongoDBRef("tests", test.Id);
            MongoDBRef s = new MongoDBRef("students", student.Id);

            var collection = db.GetCollection<StudentTest>("studenttest");

            StudentTest studentTest = new StudentTest
            {
                Test = t,
                Student = s,
                StudentAnswers = answers
            };

            collection.Insert(studentTest);

            //student.Tests.Add(t);
            //5test.Students.Add(s);

            var studentcollection = db.GetCollection<Student>("students");
            student.Tests.Add(t);

            studentcollection.Save(student);

            var testcollection = db.GetCollection<Test>("tests");
            test.Students.Add(s);

            testcollection.Save(test);

            /*var psicollection = db.GetCollection<Pas>("psi");
            pas.dostignuca.Add(new MongoDBRef("dostignuca", dostignuce.Id));

            psicollection.Save(pas);*/

        }

        public StudentTest GetStudentTest(Test test, Student student)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");

            var studenttestCollection = db.GetCollection("studenttest");
            //Test t = GetTest(name);
            MongoDBRef test1 = new MongoDBRef("tests", test.Id);

            //Student s = GetStudent(studentName);
            MongoDBRef student1 = new MongoDBRef("students", student.Id);

            var query = (from st in studenttestCollection.AsQueryable<StudentTest>()
                         where st.Test == test1 || st.Student == student1
                         select st).FirstOrDefault();

            return query;
        }

        public void UpdateGrade(Test test, Student student, int ocena)
        {

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("dbSchool");

            var studenttestCollection = db.GetCollection("studenttest");
            //Test t = GetTest(name);
            MongoDBRef test1 = new MongoDBRef("tests", test.Id);

            //Student s = GetStudent(studentName);
            MongoDBRef student1 = new MongoDBRef("students", student.Id);


            StudentTest dd = GetStudentTest(test, student);

                var query = Query.EQ("Id", dd.Id);

            dd.Grade = ocena;

            var up = MongoDB.Driver.Builders.Update.Set("Grade", ocena);

            studenttestCollection.Update(query, up);
            studenttestCollection.Save(dd);
            

        }
    }
}