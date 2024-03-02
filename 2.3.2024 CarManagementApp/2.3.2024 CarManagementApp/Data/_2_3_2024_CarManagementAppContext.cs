using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _2._3._2024_CarManagementApp.Models;

namespace _2._3._2024_CarManagementApp.Data
{
    public class _2_3_2024_CarManagementAppContext : DbContext
    {
        public _2_3_2024_CarManagementAppContext (DbContextOptions<_2_3_2024_CarManagementAppContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }

        public DbSet<_2._3._2024_CarManagementApp.Models.Users> Users { get; set; } = default!;
    }
}
