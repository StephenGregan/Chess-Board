using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tile = { "x", "o" };

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (i % 2 != 0)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write(tile[0]);
                        }
                        else
                        {
                            Console.Write(tile[1]);
                        }
                    }
                    else
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write(tile[1]);
                        }
                        else
                        {
                            Console.Write(tile[0]);
                        }
                    }
                }
                Console.Write("\r\n");
                Console.ReadLine();
            }
        }
    }
}
