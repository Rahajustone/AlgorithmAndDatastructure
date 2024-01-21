using System;
using System.Collections.Generic;

namespace AlgorithmAndDatastructure.SortingAlgorithms.QuestionLeetCode
{
    public class TwoSum
    {
        public static int[] TwoSumMethod(int target, params int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                var temp = target - arr[i];
                if (map.ContainsKey(temp))
                {
                    return new int[] {map[temp], i};
                }

                if (!(map.ContainsKey(arr[i])))
                {
                    map.Add(map[i], i);
                }
                
            }

            throw new Exception("not found"); 
        }
    }



	public class ThreeSum
	{
        // Brute force solution
        public static void ThreeSumMethod(params int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var target = -1* nums[i];
                int temp = target - nums[i];

                for (int j = 0; i < nums.Length; i++)
                {
                    var t = (target - nums[i]) - nums[j];
                    if (t == 0)
                    {
                        res.Add(new List<int> { (1)*target, nums[i], nums[j] });
                    }
                }
            }


            foreach (var item in res)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);

                }
            }



            //return res;
        }
    }
}

