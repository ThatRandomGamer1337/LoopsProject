using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Program
    {
        static bool gameOver;
        static int x;
        static int y;

        static void Main(string[] args)
        {
            // - - - - - - - -

            gameOver = false;

            x = 10;
            y = 10;

            // - - - - - - - -

            while (gameOver == false)
            {
                playerUpdate();
                playerDraw();

            }

            Console.Clear();
            Console.WriteLine("GAME OVER");
            Console.ReadKey(true);

            // - - - - - - - -
        }

        static void playerUpdate()
        {
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);

            if (input.KeyChar == 'w' && y > 0)
            {
                y = y - 1;
            }

            if (input.KeyChar == 's' && y > 0)
            {
                y = y + 1;
            }

            if (input.KeyChar == 'a' && x > 0)
            {
                x = x - 1;
            }

            if (input.KeyChar == 'd' && x > 0)
            {
                x = x + 1;
            }

            if (input.Key == ConsoleKey.Escape)
            {
                gameOver = true;
            }

            // DEBUG: Console.Write("(" + x + "), " + "(" + y + ")");
        }

        static void playerDraw()
        {

            Console.SetCursorPosition(x, y);
            Console.Write("@");

        }


    }
}
