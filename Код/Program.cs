using System;
using System.Collections.Generic;

namespace Laba_1
{
    class Program 

    { 
        static int Min(int[] item)
        {
            int min = item[0];
            int index = 0;
            for (int i = 1; i < item.Length; i++)
                if (min > item[i])
                {
                    min = item[i];
                    index = i;
                }
            return index;
        }
        static void Main(string[] args)
        {
            int klient = Convert.ToInt32(Console.ReadLine());
            List<string> spisok = new List<string>(); 
            int[] parik_time = new int[3] {0,0,0};
            for (int i=0; i < klient; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int minutes = Convert.ToInt32(s[0]) * 60 + Convert.ToInt32(s[1]);
                int min = Min(parik_time);
                if (parik_time[min] < minutes)
                {
                    parik_time[min] = minutes + 30;
                }
                else
                {
                    parik_time[min] += 30;
                }
                spisok.Add(Convert.ToString(parik_time[min] / 60 + " " + parik_time[min] % 60));
            }
            foreach (var item in spisok)
            {
                Console.WriteLine(item);
            }            
        }
    }
}