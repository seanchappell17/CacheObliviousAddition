# Cache Oblivious Large Number Addition in C#

## Description

This repository contains a C# console application designed to perform cache-oblivious addition on extremely large numbers. The program first generates these 
large numbers, saves them into individual text files, and then adds them using a cache-oblivious strategy. The final addition result is saved in an output text 
file.

## Features

### Number Generation

The `NumberGenerator` class is designed to generate large numbers:

- `GenerateNumber1` & `GenerateNumber2`: These methods initiate the number generation process for two separate numbers and save them into "number1.txt" and "number2.txt"
- respectively. The generation process's elapsed time is printed upon completion.

- `GenerateNumber`: A utility function to generate large numbers and save them into a specified file. It employs nested loops, each writing a repeated string of a particular
- digit to the file. This method will create a number that's roughly 3,220,383,898 bytes in size.

### Cache-Oblivious Addition

The `CacheObliviousAddition` class performs the addition:

- Reads numbers from the two generated files in chunks.
  
- Executes an efficient addition algorithm that is designed to work well even without using C#'s built-in `BigInteger` class.

- Writes the result in chunks to "addition_result.txt", mitigating cache misses and decreasing memory usage.

- The addition operation's time is recorded and printed upon completion.

## Instructions

**NOTE**: Please ensure you have at least 10GB of free space before running the program due to the size of the numbers being generated and manipulated.

1. Start the application.
2. Two large numbers will be generated and saved in "number1.txt" and "number2.txt".
3. The numbers will be read and added together using the cache-oblivious algorithm.
4. The result will be saved in "addition_result.txt".
5. Elapsed time for both number generation and addition will be printed to the console.

## Implementation Details

### Main Workflow (Program Class)

The primary execution workflow is contained in the `Program` class:

1. Initiate the `NumberGenerator` class and generate two large numbers.
2. Initialize the `CacheObliviousAddition` class and perform the addition.
3. Console messages guide users through each step and display the time taken for each major operation.

## Credits

- Created by: Sean R Chappell
- Created on: April 13th, 2023
- Course: CSC 4101 - Extra Credit

---
