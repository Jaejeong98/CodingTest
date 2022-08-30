using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 정렬
{
    class n_2750_2
    {
		static void Main(string[] args)
        {
			int n=int.Parse(Console.ReadLine());
			int[] arr = new int[n];
			for (int i = 0; i < n; i++)
				arr[i] = int.Parse(Console.ReadLine());
			for(int i=0; i<n-1; i++)
            {
				for(int j=i+1; j<n; j++)
                {
                    if (arr[i] > arr[j])
                    {
						int num = arr[i];
						arr[i] = arr[j];
						arr[j] = num;
                    }
                }
            }
			foreach (int i in arr)
				Console.WriteLine(i);
        }
    }
}