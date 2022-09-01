using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 집합과맵
{
    class n_1764
    {
        static void _Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<string> hash = new HashSet<string>();
            List<string> list2 = new List<string>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr[0]; i++)
                hash.Add(Console.ReadLine());
            for(int i=0; i < arr[1]; i++)
            {
                string st = Console.ReadLine();
                if (hash.Contains(st))
                    list2.Add(st);
            }
            list2.Sort();
            sb.Append(list2.Count + "\n");
            foreach (var i in list2)
                sb.Append(i+"\n");
            Console.Write(sb);
        }
    }
}
/*import java.io.*;
import java.util.*;

public class Main {
	public static void main(String[] args)throws IOException{
		BufferedReader br=new BufferedReader(new InputStreamReader(System.in));
		BufferedWriter bw=new BufferedWriter(new OutputStreamWriter(System.out));
		HashSet<String> hash = new HashSet();
		ArrayList<String> list = new ArrayList<>();
		String[] st=br.readLine().split(" "), str=new String[Integer.parseInt(st[1])];
		for(int i=0; i<Integer.parseInt(st[0]); i++)
			hash.add(br.readLine());
		for(int i=0; i<Integer.parseInt(st[1]); i++) {
			str[i]=br.readLine();
			if(hash.contains(str[i])==true)
				list.add(str[i]);
		}
		Collections.sort(list);
		bw.write(list.size()+"\n");
		for(int i=0; i<list.size(); i++)
			bw.write(list.get(i)+"\n");
		bw.flush();bw.close();
	}
}*/