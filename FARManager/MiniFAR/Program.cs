﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFAR
{
    class Program
    {
        static void Main(string[] args)
        {
            FAR far = new FAR(@"C:\");

            bool quit = false;

            while (!quit)
            {
                far.Draw();
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.Escape:
                        quit = true;
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.Backspace:
                    case ConsoleKey.Enter:
                    case ConsoleKey.R:
                        far.Process(pressedKey);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
