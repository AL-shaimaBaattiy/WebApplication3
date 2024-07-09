using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class TrainingSystemContext : DbContext
    {
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SupportTicket> SupportTickets { get; set; }
        public DbSet<CourseClassification> CourseClassifications { get; set; }
        public DbSet<CertificateTemplate> CertificateTemplates { get; set; }
        public DbSet<CourseSchedule> CourseSchedules { get; set; }
        public DbSet<RegisteredCourse> RegisteredCourses { get; set; }
    }
}