using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_exm
{
    public class Solution
    {
        public int Jump(int[] nums)
        {
            int last_maxjump = 0;
            int maxJump = 0;
            int j = 0;
            for (int i = 0;i<nums.Length ; i++)
            {

                if (nums[i] + i > maxJump)
                {
                    maxJump = nums[i] + i;
                }
                if (i >= last_maxjump && i < nums.Length - 1)
                {
                    last_maxjump = maxJump; // current maxJump
                    j++;
                }
            }

            return j;
        }
        static void Main(string[] args)
        {
            Solution ass = new Solution() ;
            int l = int.Parse(Console.ReadLine());
            int[] people = new int[l];
            for (int i = 0; i < l; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(ass.Jump(people));
            Console.ReadKey();
        }
    }
}
