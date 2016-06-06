using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new char[,] { { '0', '0', '0', '1' }, { '1', '1', '0', '1' }, { '1', '1', '1', '1' }, { '0', '1', '1', '1' }, { '0', '1', '1', '1' } };

            _221_Maximal_Square b = new _221_Maximal_Square();
            var c = b.MaximalSquare(a);

            Console.ReadLine();
        }
    }
}
