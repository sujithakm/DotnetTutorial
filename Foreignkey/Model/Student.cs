using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Foreignkey.Model
{
    public class Student
    {

        [Key]
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime Dob { get; set; }
        public List<MarkList> MarkLists { get; set; } = new List<MarkList>();
    }



    public class MarkList
    {

        [Key]
        public string MarkId { get; set; }

        [ForeignKey("StudentId")]
        public string StudentId { get; set; }



        public int M1 { get; set; }

        public int M2 { get; set; }

        public int M3 { get; set; }
    }
}