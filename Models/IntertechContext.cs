using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CoreSample.Models
{
    public class IntertechContext: DbContext     
    {
       public IntertechContext(DbContextOptions<IntertechContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
    }

    public class User{
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

    }

     public class UserModel{
        
        public string Username { get; set; }

        public string Email { get; set; }
    }
}
