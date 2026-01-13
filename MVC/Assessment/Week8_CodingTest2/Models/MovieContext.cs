using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Week8_CodingTest2.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("name=connectstr") { }

        public DbSet<Movies> Movie { get; set; }
    }
}