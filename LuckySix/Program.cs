using System;
using System.Collections.Generic;

namespace LuckySix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 1, 1, 2, 3 };
         
            Console.WriteLine(LuckySix(testArray));
        }

        public static bool LuckySix(int[] inputNumbers)
        {
            bool isConditionSatisfied = false;
            int sum = 0;
            int targetValue = 6;
            int len = inputNumbers.Length;
            int newValue;
            int oldValue;
            int bufferLength = 3;
            Queue<int> buffer = new Queue<int>();
            bool isBufferLoaded = false;
            // Init buffer queue
            for(int i = 0; i < bufferLength; i++)
            {
                buffer.Enqueue(0);
            }

            for (int j = 0; !isConditionSatisfied && j < len; j++)
            {
                oldValue = buffer.Dequeue();
                newValue = inputNumbers[j];
                buffer.Enqueue(newValue);
                sum += newValue - oldValue;

                if(!isBufferLoaded && j >= bufferLength - 1)
                {
                    isBufferLoaded = true;
                }

                if(isBufferLoaded && sum == targetValue)
                {
                    isConditionSatisfied = true;
                }
            }
            
            return isConditionSatisfied;

        }
    }
}
