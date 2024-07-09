using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class RegisteredCourse
    {
        public int User_ID { get; set; }
        public int Course_ID { get; set; }
        public string Attendance_Status { get; set; }
        public string Evaluation_Status { get; set; }
        public string Certificate_Status { get; set; }
        public virtual User User { get; set; }
        public virtual CourseSchedule CourseSchedule { get; set; }
    }
}