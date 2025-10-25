using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstAPI_Project.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MyFirstAPI_Project.Infrastructure.Models;

namespace MyFirstAPI_Project.Infrastructure
{
    public class DBContext: DbContext
    {
        private readonly static string CONN_STRING = "Server=MASELAELOG;Database=MyFirstAPI_Project_ToDo;User=test_db_user;Password=p@55w0rd;TrustServerCertificate=True;";

        public DBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONN_STRING);
        }

        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ToDoCategory> ToDoCategories { get; set; }
    }
}
