using System;
using System.Globalization;
using DecQuartApp.Entities;

namespace DecQuartApp
{
    class Program 
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Omg that's my coutry");
            Comment c2 = new Comment("Lol, stay safe bruh and keep us updated :D");
            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand",
                "I'm going to visit this wonderful contry!:)", 12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good Night honey! Mum lov u babe");
            Comment c4 = new Comment("May the force be With you...#starwarsreferences");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"), "Good night! T-that's all folks!", "See u tomorrow-land", 5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}