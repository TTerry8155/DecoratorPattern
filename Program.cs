using DecoratorPattern.Model;
using DecoratorPattern.Model.Decorators;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create book
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            //Create audio tape
            AudioTape audioTape = new AudioTape("Morgan Freeman", "The Wish Giver", "Bill Brittain", 24, 600);
            audioTape.Display();

            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video rentable:");

            Rentable rentedVideo = new Rentable(video);
            rentedVideo.RentItem("Customer #1");
            rentedVideo.RentItem("Customer #2");

            rentedVideo.Display();

            Console.WriteLine("\nMaking audio tape reservable");

            Reservable reservedAudioTape = new Reservable(audioTape);
            reservedAudioTape.ReserveItem("Customer #3");
            reservedAudioTape.ReserveItem("Customer #4");

            reservedAudioTape.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}