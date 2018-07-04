using System;

namespace Travel
{
    class Program;
    {
        static void Main(string[] args)
    {
        string Weather;
        int length;
        Console.Writeline("Weather:");
        Weather = Console.Readline();
        Console.Writeline("Length:");
        Length = Converts.Toint32 (Console.Readline());
    }
    if (Weather == "Sunny") {
        if (length < 10 ){
            Console.Writeline("Venicle:None");
        }
        else if (length < 40 ){
            Console.Writeline("Venicle:Bike");
        }  
        else if (length < 400 ){
            Console.Writeline("Venicle:Car");
        }   
        else if (length < 900 ){
            Console.Writeline("Venicle:Train");
    } 
        else if (length >= 900 ){
            Console.Writeline("Venicle:Plane");
        }    
    } 
    else if (Weather == "rainy") {
        if (length < 10) {
            Console.Writeline("Venicle:Car");
            Console.Writeline("Ride carefully");
        }
        else if (length < 40) {
            Console.Writeline("Venicle:Car");
            Console.Writeline("Ride carefully");
        }    
    }
