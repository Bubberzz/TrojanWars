using System;

namespace TrojanWars
{
    internal static class Tools
    {
        public static void ColourOfWriteLine(string text, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
