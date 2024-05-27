using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tạo một danh sách các số nguyên
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);

        foreach (int num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
