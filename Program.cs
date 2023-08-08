// +--------------------------------------------------------------+
// |                 Created by: Sean R Chappell                  | 
// |                 Created on: April 13th, 2023                 |
// |                 For: CSC 4101 - Extra Credit                 |
// +--------------------------------------------------------------+

// +--------------------------------------------------------------+
// |                    *** IMPORTANT ***                         |
// |        PLEASE MAKE SURE TO HAVE 10GB OF FREE SPACE           |
// |        AVAILABLE PRIOR TO RUNNING THIS PROGRAM               |
// |                                                              |
// | This code consists of a C# console application that generates| 
// | two large numbers, saves them into text files ("number1.txt" |
// | and "number2.txt"), and then adds these numbers using a      |
// | cache-oblivious addition algorithm. The `NumberGenerator`    |
// | class generates the large numbers through nested loops and   |
// | concatenation of digit strings. The `CacheObliviousAddition` |
// | class reads the numbers from the files in chunks, reverses   |
// | them, and adds them using a carry-based addition algorithm.  |
// | The result is written to an output file                      |
// | ("addition_result.txt") in chunks, mitigating cache misses   |
// | and decreasing memory usage. The addition algorithm is       |
// | designed to perform well without using C#'s built-in         |
// | `BigInteger` class, while still being mostly cache-oblivious.| 
// | The program utilizes the `Stopwatch` class to measure the    |
// | time taken for number generation and addition calculations,  |
// | and reports the elapsed time at each stage.                  |
// +--------------------------------------------------------------+

class Program
{
    static Task Main(string[] args)
    {
        Console.WriteLine("\t\t*** PROGRAM STARTED ***\n");

        NumberGenerator numberGenerator = new NumberGenerator();
        numberGenerator.GenerateNumber1();
        numberGenerator.GenerateNumber2();

        CacheObliviousAddition addition = new CacheObliviousAddition();
        addition.AddLargeNumbers();

        Console.WriteLine("\t\t*** PROGRAM COMPLETED ***");

        return Task.CompletedTask;
    }
}
