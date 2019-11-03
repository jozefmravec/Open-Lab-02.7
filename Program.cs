using System;

namespace OpenLab2._7a
{
    class Program
    {
        static void Main(string[] args)
        {
            Christmas christmas = new Christmas();
                Console.WriteLine(christmas.IsTimeForCookies(2019, 12, 24));
        }
    }
}
