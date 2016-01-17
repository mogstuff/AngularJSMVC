using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularJSMVC.Models
{
    public class BookDBContext : DbContext
    {
        public BookDBContext()
            : base("name=BookDBContext") 
        { 
        
        }
        
        
        public DbSet<Book> book { get; set; }

    }
}