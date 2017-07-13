using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Model.Decorators
{
    public abstract class Decorator : LibraryComponent
    {
        protected LibraryComponent libraryComponent;

        // Constructor
        public Decorator(LibraryComponent libraryComponent)
        {
            this.libraryComponent = libraryComponent;
        }

        public override void Display()
        {
            libraryComponent.Display();
        }
    }
}
