using System;
namespace LeetCodeSamplesConsole
{
    namespace LeetCodeSamples
    {
        public class ArrayProblemMaxConecutiveOnes
        {
            public int FindMaxConsecutiveOnes(int[] nums)
            {

                if (nums.Length < 1)
                    return nums.Length;

                if (nums.Length > (10 * 10 * 10 * 10 * 10))
                    return nums.Length;

                var consec = 0;
                var lastKnownConsecCount = 0;
                for (int i = 0; i <= nums.Length - 1; i++)
                {
                    if (nums[i] > 1)
                    {
                        lastKnownConsecCount = 0;
                        break;
                    }
                    if (nums[i] == 1)
                        consec++;
                    if (nums[i] == 0)
                    {
                        if (consec > lastKnownConsecCount)
                            lastKnownConsecCount = consec;
                        consec = 0;
                    }

                }
                if (consec > lastKnownConsecCount)
                    lastKnownConsecCount = consec;
                return lastKnownConsecCount;
            }
        }
    }
}

