using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationCoreMVC.Models;

namespace WebApplicationCoreMVC.Data
{
    public class WebApplicationCoreMVCContext : DbContext
    {
        public WebApplicationCoreMVCContext (DbContextOptions<WebApplicationCoreMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; } = default!;
    }
}
