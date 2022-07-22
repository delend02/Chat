using Chat.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.DAL.EntityFramework
{
    public class ChatingContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }

        public ChatingContext(DbContextOptions<ChatingContext> options) 
            : base(options)
        {

        }
    }
}
