using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Chess
{
    internal class Program
    {
        static int Main(string[] args)
        {
            char[] lines = new char[8] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            int[] raws = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Input the start line capital letter: ");
            char start_line = char.Parse(Console.ReadLine());

            if (LineChecker(start_line, lines) == 0)
            {
                return 0;
            }

            Console.WriteLine("Input the start raw: ");
            int start_raw = int.Parse(Console.ReadLine());

            if (RawChecker(start_raw, raws) == 0)
            {
                return 0;
            }

            Console.WriteLine("Input the finish line capital letter: ");
            char finish_line = char.Parse(Console.ReadLine());

            if (LineChecker(finish_line, lines) == 0)
            {
                return 0;
            }

            Console.WriteLine("Input the finish raw: ");
            int finish_raw = int.Parse(Console.ReadLine());

            if (RawChecker(finish_raw, raws) == 0)
            {
                return 0;
            }

            if (InputLogicChecker(start_line, start_raw, finish_line, finish_raw) == 0)
            {
                return 0;
            }

            BishopMoveCheck(start_line, start_raw, finish_line, finish_raw, lines, raws);
            KnightMoveCheck(start_line, start_raw, finish_line, finish_raw, lines, raws);
            RookMoveCheck(start_line, start_raw, finish_line, finish_raw, lines, raws);
            QueenMoveCheck(start_line, start_raw, finish_line, finish_raw, lines, raws);
            KingMoveCheck(start_line, start_raw, finish_line, finish_raw, lines, raws);

            Console.ReadKey();

            return 1;
        }

        static int LineChecker(char line, char[] lines)
        {
            if (!Array.Exists(lines, element => element == line))
            {
                Console.WriteLine("Invalid line input!");
                return 0;
            }

            else
            {
                return 1;
            }
        }

        static int RawChecker(int raw, int[] raws)
        {
            if (!Array.Exists(raws, element => element == raw))
            {
                Console.WriteLine("Invalid raw input!");
                return 0;
            }

            else
            {
                return 1;
            }

        }

        static int InputLogicChecker(char start_line, int start_raw, char finish_line, int finish_raw)
        {
            if (start_line == finish_line && start_raw == finish_raw)
            {
                Console.WriteLine("Incorrect input: start and finish points are equal!");
                return 0;
            }

            else
            {
                return 1;
            }
        }

        static void BishopMoveCheck(char start_line, int start_raw, char finish_line, int finish_raw, char[] lines,int[] raws) //Slon
        {
            if (Array.IndexOf(lines, finish_line) - Array.IndexOf(lines, start_line) == Array.IndexOf(raws, finish_raw) - Array.IndexOf(raws, start_raw))
            {
                Console.WriteLine("Correct move for the Bishop!");
            }

            else
            {
                Console.WriteLine("Incorrect move for the Bishop!");
            }

        }

        static void KnightMoveCheck(char start_line, int start_raw, char finish_line, int finish_raw, char[] lines, int[] raws) //Kon'
        {
            if (Math.Abs(Array.IndexOf(lines, finish_line) - Array.IndexOf(lines, start_line)) == 2 && Math.Abs(Array.IndexOf(raws, finish_raw) - Array.IndexOf(raws, start_raw)) == 1)
            {
                Console.WriteLine("Correct move for the Knight!");
            }

            else if (Math.Abs(Array.IndexOf(lines, finish_line) - Array.IndexOf(lines, start_line)) == 1 && Math.Abs(Array.IndexOf(raws, finish_raw) - Array.IndexOf(raws, start_raw)) == 2)
            {
                Console.WriteLine("Correct move for the Knight!");
            }

            else
            {
                Console.WriteLine("Incorrect move for the Knight!");
            }
        }

        static void RookMoveCheck(char start_line, int start_raw, char finish_line, int finish_raw, char[] lines, int[] raws) //Lad'ya
        {
            if (Array.IndexOf(lines, finish_line) - Array.IndexOf(lines, start_line) == 0 || Array.IndexOf(raws, finish_raw) - Array.IndexOf(raws, start_raw) == 0)
            {
                Console.WriteLine("Correct move for the Rook!");
            }

            else
            {
                Console.WriteLine("Incorrect move for the Rook!");
            }

        }

        static void QueenMoveCheck(char start_line, int start_raw, char finish_line, int finish_raw, char[] lines, int[] raws) //Fer'z
        {
            if (Array.IndexOf(lines, finish_line) - Array.IndexOf(lines, start_line) == Array.IndexOf(raws, finish_raw) - Array.IndexOf(raws, start_raw))
            {
                Console.WriteLine("Correct move for the Queen!");
            }

            else if (Array.IndexOf(lines, finish_line) - Array.IndexOf(lines, start_line) == 0 || Array.IndexOf(raws, finish_raw) - Array.IndexOf(raws, start_raw) == 0)
            {
                Console.WriteLine("Correct move for the Queen!");
            }

            else if (Math.Abs(Array.IndexOf(lines, finish_line) - Array.IndexOf(lines, start_line)) <= 1 && Math.Abs(Array.IndexOf(raws, finish_raw) - Array.IndexOf(raws, start_raw)) <= 1)
            {
                Console.WriteLine("Correct move for the Queen!");
            }

            else
            {
                Console.WriteLine("Incorrect move for the Queen!");
            }

        }

        static void KingMoveCheck(char start_line, int start_raw, char finish_line, int finish_raw, char[] lines, int[] raws) //Korol'
        {
            if (Math.Abs(Array.IndexOf(lines, finish_line) - Array.IndexOf(lines, start_line)) <= 1 && Math.Abs(Array.IndexOf(raws, finish_raw) - Array.IndexOf(raws, start_raw))<=1)
            {
                Console.WriteLine("Correct move for the King!");
            }

            else
            {
                Console.WriteLine("Incorrect move for the King!");
            }
        }


    }
}
