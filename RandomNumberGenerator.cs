using System;


namespace C_Sharp_DuplicateDeleter{

    public class RandomNumberGenerator{

        Random random{get;set;}

        public RandomNumberGenerator(){
            random = new Random();
         }
        public int[] randomNumberArray(int length, int topRange){
            int [] randomArray = new int[length];
            for(int i = 0; i<length; i++){
                randomArray[i] = random.Next(topRange);
            }
            return randomArray;
        }

    }
}