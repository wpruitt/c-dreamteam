using System;
using System.Collections.Generic;

namespace dreamteam
{
    public class Student
    {
        public string Specialty { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FullName 
            {
                get
                {
                    return (string.Concat(FirstName, LastName));
                }
            }
            public virtual void Work()
            {
                Console.WriteLine("Do Work");
            }
    }
    public class Jordan : Student
    {
        public override void Work()
        {
            Console.WriteLine("Talk about stuff... and get shit done....");
        }
    }
    public class Madeline : Student
    {
        public override void Work()
        {
            Console.WriteLine("Pull Requests....");
        }
    }
    public class Jackie : Student
    {
        public override void Work()
        {
            Console.WriteLine("Gimme a snack and let me go...");
        }
    }
    public class Tamela : Student
    {
        public override void Work()
        {
            Console.WriteLine("Working the Horsehole");
        }
    }public class Azim : Student
    {
        public override void Work()
        {
            Console.WriteLine("I got it");
        }
    }public class Kevin : Student
    {
        public override void Work()
        {
            Console.WriteLine("Done");
        }
    }
    public class Willie : Student
    {
        public override void Work()
        {
            Console.WriteLine("........hold up, are you sure?");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> serverSide = new List<Student>();
            List<Student> clientSide = new List<Student>();


            serverSide.Add(new Jordan(){
                FirstName = "Jordan"
            });
            serverSide.Add(new Madeline(){
                FirstName = "Madeline"
            });
            serverSide.Add(new Jackie(){
                FirstName = "Jackie"
            });
            clientSide.Add(new Tamela(){
                FirstName = "Tamela"
            });
            clientSide.Add(new Azim(){
                FirstName = "Azim"
            });
            clientSide.Add(new Kevin(){
                FirstName = "Kevin"
            });

            foreach (Student student in serverSide)
            {
                student.Work();
            }
            foreach (Student student in clientSide)
            {
                 student.Work();
            }
        }
    }
}
