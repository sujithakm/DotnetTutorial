using Foreignkey.Model;
using System;
using System.Collections.Generic;
namespace Foreignkey
{
    class Program
    {
        static void Main(string[] args)
        {
            



                using (StudentAppDb dbContext = new StudentAppDb())
                {


                //Student s1 = new Student();
                //s1.StudentId = Guid.NewGuid().ToString();
                //s1.FirstName = "Vishnu";
                //s1.LastName = "kumar";
                Student s2 = new Student();
                s2.StudentId = Guid.NewGuid().ToString();
                    s2.Age = 19;


                    s2.MarkLists.Add(new MarkList()
                    {

                        MarkId = Guid.NewGuid().ToString(),

                        StudentId = s2.StudentId,
                        M1 = 90,
                        M2 = 23,
                        M3 = 100,


                    }); ;


                    dbContext.Students.Add(s2);
                    // dbContext.MarkLists.Add(m1);

                    dbContext.SaveChanges();
                }
                Console.WriteLine("Hello World!");
            }
        }
    }