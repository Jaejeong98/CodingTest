using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 재귀
{
    class n_24060
    {
        public static int[] tmp, arr;
        public static int cnt = 0,ans=-1;
        public static void Merge_sort(int[] nums, int p, int r) {
            if (p < r)
            {
                int q = (p + r) / 2;
                Merge_sort(nums, p, q);
                Merge_sort(nums, q + 1, r);
                Merge(nums, p, q, r);
            }
        }
        public static void Merge(int[] nums, int s, int m, int e)
        {
            int i = s, j = m + 1, t = 0;
            while(i<=m && j <= e)
                tmp[t++] = nums[i] <= nums[j] ? nums[i++] : nums[j++];
            while (i <= m)
                tmp[t++] = nums[i++];
            while(j<=e)
                tmp[t++] = nums[j++];
            i = s; t = 0;
            while (i <= e)
            {
                cnt++;
                if (cnt == arr[1])
                {
                    ans = tmp[t];
                    break;
                }
                nums[i++] = tmp[t++];
            }
        }
        public static void _Main(string[] args)
        {
            arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            tmp = new int[arr[0]];
            Merge_sort(nums, 0, arr[0]-1);
            Console.WriteLine(ans);
        }
    }
}
