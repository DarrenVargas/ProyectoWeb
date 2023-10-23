using Guests.Application.Contracts.Contexts;
using Guests.Domain.EntityModels.Guests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) 
            : base(options)
        {

        }

        public DbSet<Guest> Guests { get; set; }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}
