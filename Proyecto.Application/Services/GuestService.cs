using Guests.Application.Contracts;
using Guests.Application.Contracts.Repositories;
using Guests.Domain.DTOs.Guests;
using Entities = Guests.Domain.EntityModels.Guests;
using Guests.Domain.InputModels.Guests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests.Application.Services
{
    public class GuestService : IGuestService
    {

        private readonly IGuestRepository _repository;

        public GuestService(IGuestRepository _repository)
        {
            this._repository = _repository;
        }

        public Guest Get(int id)
        {
            var guest = _repository.Get(s => s.Id == id);
            return new Guest(guest.Id, guest.FirstName, guest.LastName);
        }   

        public List<Guest> List()
        {
            return _repository
                .GetAll(s => s.ParentId == null,
                includes: i => i.Companions).ToList()
                .ConvertAll(guest => new Guest(guest.Id, guest.FirstName, guest.LastName));
        }

        public bool Insert(NewGuest newGuest)
        {
            Entities.Guest guest = new Entities.Guest(newGuest.FirstName, newGuest.LastName);
            _repository.Insert(guest);
            _repository.Save();
            return true;
        }

        public bool Update(ExistingGuest existingGuest)
        {
            Entities.Guest guest = _repository.Get(s =>s.Id == existingGuest.Id);
            guest.Update(existingGuest.FirstName, existingGuest.LastName);
            _repository.Update(guest);
            _repository.Save();
            return true;
        }

        public bool Delete(int id)
        {
            Entities.Guest guest = _repository.Get(s => s.Id == id);
            _repository.Delete(guest);
            _repository.Save();
            return true;
        }
    }
}
