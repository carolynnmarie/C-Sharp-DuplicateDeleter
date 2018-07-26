using System;
using System.Collections.Generic;

namespace C_Sharp_DuplicateDeleter{

    public class DuplicateDeleter{

        int[] randomArray;
        public DuplicateDeleter(int[] array) => randomArray = array;
        public int[] removeDuplicates(int maxNumberOfDuplications){
            List<int> list = new List<int>();
            foreach(var item in randomArray){
                if(countDuplicates(item,randomArray) < maxNumberOfDuplications){
                    list.Add(item);
                }
            }
            return list.ToArray();
        }

        private int countDuplicates(int id, int[] array){
            int count = 0;
            foreach(var item in array){
                if(item == id) count++;
            }
            return count;
        }

        public int[] removeExactDuplications(int numberOfDuplications){
            List<int> list = new List<int>();
            foreach(var item in randomArray){
                if(countDuplicates(item,randomArray)!=numberOfDuplications){
                    list.Add(item);
                }
            }
            return list.ToArray();
        }

    }
    
}