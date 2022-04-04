using MVC_Practical.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC_Practical {
    public class ApplicationDBContext : DbContext{
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {

        }

        public DbSet<Student> Student {
            get;
            set;
        }


        public DbSet<Teacher> Teacher {
            get;
            set;
        }
    }
}