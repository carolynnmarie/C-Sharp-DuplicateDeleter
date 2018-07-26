using System;

namespace C_Sharp_DuplicateDeleter
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumberGenerator generator = new RandomNumberGenerator();
            int [] randomArray = generator.randomNumberArray(15, 8);
            Console.WriteLine(String.Join(" ",randomArray));

            DuplicateDeleter deleter = new DuplicateDeleter(randomArray);
            int[] deleted = deleter.removeDuplicates(3);
            Console.WriteLine(String.Join(" ",deleted));
            
            int[] exactDeleted = deleter.removeExactDuplications(3);
            Console.WriteLine(String.Join(" ",exactDeleted));
        }
    }
}
