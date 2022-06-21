using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGamesList = new List<string>();
            videoGamesList.Add("Legend of Zelda");
            videoGamesList.Add("Halo");
            videoGamesList.Add("Destiny");
            videoGamesList.Add("Super Mario Bros.");
            videoGamesList.Add("World of Warcraft");
            videoGamesList.Add("Call of Duty");
            videoGamesList.Add("Smash Brothers");
            videoGamesList.Add("Mass Effect");

            var nameByLength = videoGamesList.OrderBy(x => x.Length);
            foreach(var game in nameByLength)
            {
                Console.WriteLine(game);
            }

        }
    }
}
