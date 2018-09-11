using System;
using System.Collections.Generic;

namespace C_Sharp_DuplicateDeleter{

    public class FibonacciFinder{

        public List<long> fibonacciSequence(long upperLimit){
            List<long> fSequence = new List<long>();
            long first = 0;
            long second = 1;
            long nextF = 0;
            while(second<upperLimit){
                fSequence.Add(first);
                nextF = first + second;
                first = second;
                second = nextF;
            }
            return fSequence;
        } 

        public long findNextFibonacci(long input){
            long first = 1;
            long second = 1;
            long nextF = 0;
            while(second<input){
                nextF = first + second;
                first = second;
                second = nextF;
            }
            return second;
        }
    }
}