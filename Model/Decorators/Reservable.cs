using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Model.Decorators
{
    public class Reservable : Decorator
    {
        private DateTime _dayReserved;

        private DateTime _cancellationDate;

        private List<string> _reservers = new List<string>();

        // Constructor
        public Reservable(LibraryComponent libraryComponent)
          : base(libraryComponent)
        {
        }

        public void ReserveItem(string name)
        {
            _reservers.Add(name);
            _dayReserved = DateTime.Now;
            _cancellationDate = DateTime.Now.AddDays(3);
            NumCopies--;
        }

        public void CancelReserveItem(string name)
        {
            _reservers.Remove(name);
            NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string reserver in _reservers)
            {
                Console.WriteLine(" reserved for: " + reserver);
            }
        }
    }
}
