// +--------------------------------------------------------------+
// |                 Created by: Sean R Chappell                  | 
// |                 Created on: April 13th, 2023                 |
// |                 Last Edited on: May 5th, 2023                |
// |                 For: CSC 4101 - Extra Credit                 |
// +--------------------------------------------------------------+

using System.Text;
using System.Diagnostics;

// +--------------------------------------------------------------+
// | The code for Addition, reads in the input files in chunks    |
// | and writes the result in chunks, which helps mitigate the    |
// | chances of cache misses and decrease memory usage. However,  |
// | since this implementation does utilize a more 'cache-        |
// | friendly' approach, it will perform well without using the   |    
// | built-in C# 'BigInteger' class, while still being mostly     |
// | cache-oblivious.                                             |
// +--------------------------------------------------------------+ 

public class CacheObliviousAddition
{
    public string File1Path { get; set; }
    public string File2Path { get; set; }
    public string OutputPath { get; set; }

    public CacheObliviousAddition(string file1Path, string file2Path, string outputPath)
    {
        File1Path = file1Path;
        File2Path = file2Path;
        OutputPath = outputPath;
    }

    public CacheObliviousAddition()
    {
        File1Path = "number1.txt";
        File2Path = "number2.txt";
        OutputPath = "addition_result.txt";
    }

    public void AddLargeNumbers()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        Console.WriteLine("\t\t*** CALCULATION STARTED ***");
        int chunkSize = 1024 * 1024;
        int carry = 0;

        using (StreamReader file1 = new StreamReader(File1Path, Encoding.UTF8))
        using (StreamReader file2 = new StreamReader(File2Path, Encoding.UTF8))
        using (StreamWriter output = new StreamWriter(OutputPath, false, Encoding.UTF8))
        {
            while (!file1.EndOfStream && !file2.EndOfStream)
            {
                char[] chunk1 = ReadChunk(file1, chunkSize);
                char[] chunk2 = ReadChunk(file2, chunkSize);

                Array.Reverse(chunk1);
                Array.Reverse(chunk2);

                StringBuilder result = new StringBuilder(chunkSize + 1);

                for (int i = 0; i < chunk1.Length && i < chunk2.Length; i++)
                {
                    int num1 = (int)char.GetNumericValue(chunk1[i]);
                    int num2 = (int)char.GetNumericValue(chunk2[i]);

                    int tempSum = num1 + num2 + carry;
                    carry = tempSum / 10;
                    result.Append(tempSum % 10);
                }

                if (carry > 0)
                {
                    result.Append(carry);
                    carry = 0;
                }

                char[] outputChunk = result.ToString().ToCharArray();
                Array.Reverse(outputChunk);
                output.Write(outputChunk);
            }
        }
        stopwatch.Stop();
        Console.WriteLine($"*** TIME ELAPSED FOR ADDITION CALCULATION: {stopwatch.Elapsed} ***\n");
    }

    private static char[] ReadChunk(StreamReader file, int chunkSize)
    {
        char[] buffer = new char[chunkSize];
        int bytesRead = file.ReadBlock(buffer, 0, chunkSize);
        Array.Resize(ref buffer, bytesRead);

        return buffer;
    }
}
