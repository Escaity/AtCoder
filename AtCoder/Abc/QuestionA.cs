using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    public class QuestionA
    {
        static System.IO.StreamWriter sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };

        public static void Main(string[] args)
        {
            Console.SetOut(sw);

            string S = Console.ReadLine(); // 文字列の入力
            long nl = long.Parse(Console.ReadLine()); // 整数の入力
            string[] arrStr = Console.ReadLine().Split(' '); // 文字列配列の入力
            var arrLong = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray(); // 整数配列の入力


            Console.WriteLine();

            Console.Out.Flush();
        }
    }
}
