using Guests.Domain.EntityModels.Guests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests.Application.Contracts.Repositories
{
    public interface IGuestRepository : IRepository<Guest>
    {
    }
}
