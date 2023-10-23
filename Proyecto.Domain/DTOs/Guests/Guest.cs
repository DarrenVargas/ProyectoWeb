using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests.Domain.DTOs.Guests
{
    public class Guest
    {
        private List<Guest> _companions;


        public Guest(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;

            _companions = new List<Guest>();
        }

        public int Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set;}

        public IReadOnlyList<Guest> Companios 
        { 
            get {  return _companions; } 
        }

        public bool HasChanged { get; private set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }

        public void Update(string firtName, string lastName)
        {
            HasChanged =
                !firtName.Equals(FirstName, StringComparison.OrdinalIgnoreCase) &&
                !lastName.Equals(LastName, StringComparison.OrdinalIgnoreCase);

            FirstName = firtName;
            LastName = lastName;
        }

        public void AddCompanion(string firstname, string lastname)
        {
            _companions.Add(new Guest(0,firstname,lastname));
        }
    }
}
