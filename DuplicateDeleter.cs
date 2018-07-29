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
        public int getMostCommonItem(){
            int temp = 0;
            int most = 0;
            foreach(var item in randomArray){
                if(countDuplicates(item,randomArray)>temp){
                    temp = countDuplicates(item,randomArray);
                    most = item;
                }
            }
            return  most;
        }
        public int[] deleteMultiplesOfN(int multiple){
            List<int> list = new List<int>();
            foreach(var x in randomArray){
                if(x%multiple != 0 || x == 0){
                    list.Add(x);
                }
            }
            int[] array = list.ToArray();
            return array; 
        }

        public static int[] mergeArrays(int [] objectArray, int[] objectArrayToAdd){
            int [] merged = new int[objectArray.Length + objectArrayToAdd.Length];
            objectArray.CopyTo(merged,0);
            objectArrayToAdd.CopyTo(merged,objectArray.Length);
            return merged;
        }

        }

        
    }
    