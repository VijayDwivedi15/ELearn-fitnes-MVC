using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELearning.Models
{
    public class CourseCategory
    {
        [Key]
        public Int64 CourseCategoryID { get; set; }

        public string CourseName { get; set; }

        public string Description { get; set; }

        public string Duration { get; set; }

        public float Price { get; set; }

        public string CourseImage { get; set; }

        public string InstructorID { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}