using Guests.Domain.EntityModels.Guests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests.Application.Contracts.Contexts
{
    public interface IApplicationDbContext
    {
        DbSet<Guest> Guests { get; set; }

        void Save();
    }
}
