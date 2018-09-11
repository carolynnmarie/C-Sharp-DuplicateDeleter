using System;
using System.Collections.Generic;

namespace C_Sharp_DuplicateDeleter
{
    class Program
    {
        static void Main(string[] args)
        {
            // RandomNumberGenerator generator = new RandomNumberGenerator();
            // int [] randomArray = generator.randomNumberArray(15, 8);
            // Console.WriteLine(String.Join(" ",randomArray));

            // DuplicateDeleter deleter = new DuplicateDeleter(randomArray);
            // int[] deleted = deleter.removeDuplicates(3);
            // Console.WriteLine(String.Join(" ",deleted));
            
            // int[] exactDeleted = deleter.removeExactDuplications(3);
            // Console.WriteLine(String.Join(" ",exactDeleted));

            // Console.WriteLine(String.Join(" ", deleter.deleteMultiplesOfN(2)));
            // int [] array1 = {1,2,3,4};
            // int [] array2 = {5,6,7,8};
            // int [] merged = DuplicateDeleter.mergeArrays(array1,array2);
            // Console.WriteLine(String.Join(" ", merged));
            FibonacciFinder ff = new FibonacciFinder();
            long answer = ff.findNextFibonacci(722);
            List<long> sequence = ff.fibonacciSequence(43295);
            Console.WriteLine(String.Join(", ",sequence));
        }
    }
}
