using Microsoft.EntityFrameworkCore;
using Simple.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.DAL.DAL
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) { }
     
        public DbSet<Blog> Blogs { get; set; }
    }
}
