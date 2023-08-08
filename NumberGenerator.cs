// +--------------------------------------------------------------+
// |                 Created by: Sean R Chappell                  | 
// |                 Created on: April 13th, 2023                 |
// |                 For: CSC 4101 - Extra Credit                 |
// +--------------------------------------------------------------+

using System.Diagnostics;

// +--------------------------------------------------------------+
// | The 'NumberGenerator' class will generate large numbers by   |
// | concatenating strings of digits and saves them to their own  |
// | files.                                                       |
// |                                                              |
// | The 'GenerateNumber1' method generates the 1st number & saves|
// | it to the file called "number1.txt". It creates a new        |
// | Stopwatch instance to measure the time taken to generate the |
// | number and then prints the elapsed time.                     |
// |                                                              |
// | The 'GenerateNumber2' method does the exact same thing as    |
// | the 'GenerateNumber1 method, except creates a different file |
// | called "number2.txt".                                        |
// |                                                              |      
// | The 'GenerateNumber' method generates a number and saves it  |
// | to a file with the given file name. It creates a new         |
// | StreamWriter instance to write to the file with the given    |
// | file name. The number is generated by concatenating strings  |
// | of digits using nested for loops. This method of creating a  |
// | number will make a number that's 3,220,383,898 bytes big.    |
// +--------------------------------------------------------------+

public class NumberGenerator 
{
    public void GenerateNumber1() 
    {
        Stopwatch sw = Stopwatch.StartNew();
        GenerateNumber("number1.txt");
        sw.Stop();
        Console.WriteLine("\t\t*** NUMBER 1 GENERATED ***");
        Console.WriteLine($"*** TIME ELAPSED FOR GENERATING NUMBER 1: {sw.Elapsed} ***\n");
    }

    public void GenerateNumber2() 
    {
        Stopwatch sw = Stopwatch.StartNew();
        GenerateNumber("number2.txt");
        sw.Stop();
        Console.WriteLine("\t\t*** NUMBER 2 GENERATED ***");
        Console.WriteLine($"*** TIME ELAPSED FOR GENERATING NUMBER 2: {sw.Elapsed} ***\n");
    }

    private void GenerateNumber(string fileName) 
    {
        using (StreamWriter sw = new StreamWriter(fileName)) 
        {
            for (int i = 0; i < 166; i++) 
            {
                for (int j = 0; j < 111111; j++) 
                {
                    sw.Write("1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111");
                }
                for (int j = 0; j < 11111; j++) 
                {
                    sw.Write("2222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222");
                }
                for (int j = 0; j < 11111; j++) 
                {
                    sw.Write("3333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333");
                }
                for (int j = 0; j < 11111; j++) 
                {
                    sw.Write("4444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444");
                }
                for (int j = 0; j < 11111; j++) 
                {
                    sw.Write("5555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555555");
                }
                for (int j = 0; j < 11111; j++) 
                {
                    sw.Write("6666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666");
                }
                for (int j = 0; j < 11111; j++) 
                {
                    sw.Write("7777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777");
                }
                for (int j = 0; j < 11111; j++) 
                {
                    sw.Write("8888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888");
                }
                for (int j = 0; j < 11111; j++) 
                {
                    sw.Write("9999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999");
                }
            }
        }
    }
}