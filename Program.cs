using System;
using System.Reflection.Metadata;

namespace MovieLibrary{
    class Program{
        public static void displayOptions(){
            Console.WriteLine("1. Insert a movie.\n2.Remove a movie.\n3.Display all movies.\n");
        }
        public static void Main(string[] args){
            //Movie movie =  new Movie();

            Console.WriteLine("Welcome to the movie library! \n\nPlease pick an option below.");
            
            //Console.Clear();
            
            displayOptions();
            
        }


    }
}