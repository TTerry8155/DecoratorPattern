using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Model.Decorators
{
    public class Rentable : Decorator
    {
        protected List<string> renters = new List<string>();
        
        public Rentable(LibraryComponent libraryComponent)
          : base(libraryComponent)
        {
        }

        public void RentItem(string name)
        {
            renters.Add(name);
            libraryComponent.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            renters.Remove(name);
            libraryComponent.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string renter in renters)
            {
                Console.WriteLine(" renter: " + renter);
            }
        }
    }
}
