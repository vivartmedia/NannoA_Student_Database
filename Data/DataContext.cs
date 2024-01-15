
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NannoA_Student_Database.Models;

namespace NannoA_Student_Database.Data;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
