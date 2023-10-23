using Guests.Application.Contracts.Repositories;
using Guests.Application.Diagnostics;
using Guests.Domain.EntityModels.Guests;
using Guests.Persistence.Contexts;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests.Persistence.Repositories
{
    public class GuestRepository : Repository<Guest>, IGuestRepository
    {
        public GuestRepository(ApplicationDbContext dbContext, IOptions<Guard> guard)
            : base(dbContext, guard)
        {
        }
    }
}
