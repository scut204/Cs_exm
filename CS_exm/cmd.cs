using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmd
{
    
    class tests
    {
        int n;
        enum body { a, b, c, d };
        //public IList<IList<int>> Permute(int[] nums)
        //{
        //    n = nums.Length;
        //}
        //// 对seq的循环，两层循环
        //public IList<int> Sgl_Permute(int perm) {
        //    IList<int> a = new List<int>();a.Add(1);
        //    List<int> seq = perm2seq(perm);
        //}
        public static void Main()
        {
            body[] a = (body[])Enum.GetValues(typeof(body));
            for (int i = 0; i < a.Count();i++ )
            { Console.WriteLine("{0}", a[i]); }


                Console.ReadKey();
        }
    }
}
