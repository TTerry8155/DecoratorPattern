using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Model.Decorators
{
    public class Rentable : Decorator
    {
        protected List<string> borrowers = new List<string>();

        // Constructor
        public Rentable(LibraryComponent libraryComponent)
          : base(libraryComponent)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryComponent.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryComponent.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}
