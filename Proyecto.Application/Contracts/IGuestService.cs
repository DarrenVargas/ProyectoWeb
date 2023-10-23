using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guests.Domain.DTOs.Guests;
using Guests.Domain.InputModels.Guests;

namespace Guests.Application.Contracts
{
    public interface IGuestService
    {
        Guest Get(int id);

        List<Guest> List();

        bool Insert(NewGuest newGuest);

        bool Update(ExistingGuest existingGuest);

        bool Delete(int id);
    }
}
