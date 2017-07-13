using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Model.Decorators
{
    public class Reservable : Decorator
    {
        private bool _isReserved;
        private List<string> _reservers;

        // Constructor
        public Reservable(LibraryComponent libraryComponent)
          : base(libraryComponent)
        {
        }

        public void ReserveItem(string name)
        {
            _reservers.Add(name);
            _isReserved = true;
            NumCopies--;
        }

        public void CancelReserveItem(string name)
        {
            _reservers.Remove(name);
            _isReserved = false;
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
