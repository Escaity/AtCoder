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
            string S = Console.ReadLine();
            var N = long.Parse(Console.ReadLine()); // 整数の入力
            var aS = Console.ReadLine().Split(' ').ToArray(); // 文字列配列の入力
            var aN = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray(); // 整数配列の入力

            Console.Out.Flush();
        }
    }
}
