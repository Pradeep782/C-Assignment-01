using System;
namespace MyHelloWorldApp {
   class Program{
       static void Main(string[] args){
           Console.WriteLine("Hello World!");
           Console.WriteLine("My name is Pradeep Reddy");
           
           Console.BackgroundColor = ConsoleColor.Blue;
           Console.ForegroundColor = ConsoleColor.White;
           Console.Title = "Hi Mom";
           
           Console.ReadLine();
       }
   }
}