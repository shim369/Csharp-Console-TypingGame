using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {
        var words = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig", "grape", "honeydew" };

        Console.WriteLine("タイピングゲームを開始します。Enterキーを押すとスタートです！");
        Console.ReadLine();

        var random = new Random();
        var score = 0;
        var timer = new Stopwatch();

        timer.Start();

        for (int i = 0; i < 5; i++) // 5回の単語をタイプする試み
        {
            var word = words[random.Next(words.Count)];
            Console.WriteLine($"タイプしてください: {word}");

            var userWord = Console.ReadLine();

            if (userWord == word)
            {
                score++;
                Console.WriteLine("正解！");
            }
            else
            {
                Console.WriteLine("不正解...");
            }
        }

        timer.Stop();
        Console.WriteLine($"スコア: {score} / 5");
        Console.WriteLine($"所要時間: {timer.ElapsedMilliseconds / 1000.0} 秒");

        Console.WriteLine("ゲーム終了！Enterキーを押すと終了します。");
        Console.ReadLine();
    }
}
