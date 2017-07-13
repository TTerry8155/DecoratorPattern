using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Model
{
    public class AudioTape : LibraryComponent
    {
        private string _voiceActor;
        private string _author;
        private string _title;
        private int _playTime;

        // Constructor
        public AudioTape(string voiceActor, string title, string author,
          int numCopies, int playTime)
        {
            _voiceActor = voiceActor;
            _title = title;
            _author = author;
            this.NumCopies = numCopies;
            _playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nAudio Tape");
            Console.WriteLine(" Voice Actor: {0}", _voiceActor);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" Author: {0}", _author);
            Console.WriteLine(" # Copies: {0}", NumCopies);
            Console.WriteLine(" Playtime: {0}\n", _playTime);
        }
    }
}
