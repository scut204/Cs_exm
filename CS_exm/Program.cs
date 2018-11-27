using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CS_exm
{
    public class Solution {
        public const int INT_MAX = 65535;
        public const int MOD_INT = 1000000007;
        public int NthMagicalNumber(int N, int A, int B)
        {
             
            int cmm_ab = A * B / gcd(A, B);
            int aj = cmm_ab/A;
            int bj = cmm_ab/B;
            int grp_cmm = cmm_ab / A + cmm_ab / B - 1;
            int gi = N / grp_cmm;
            int gli = N % grp_cmm;

            List<int> grp = new List<int>();
            for (int ai = 1;ai<aj;ai++)
            {
                grp.Add(A * ai);
            }

            for (int bi = 1; bi < bj; bi++)
            {
                grp.Add(B * bi);
            }
            grp.Sort();

            if (gli == 0) { return (gi * cmm_ab) % MOD_INT; }
            else { return (gi * cmm_ab + grp[gli-1])%MOD_INT; }

        }
        int  gcd(int a,int b)
        {
            int temp;
            while (b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }
        static void Main(string[] args){
            int n = 5, a = 2, b = 4;
            Solution ac = new Solution();
            Console.WriteLine(ac.NthMagicalNumber(n,a,b));
            Console.ReadKey();
        }
    }

    
}
