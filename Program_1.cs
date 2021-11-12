using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba_2
{

    class Program
    {     
        static List<string> combination = new List<string>();       
        static void Main(string[] args)
        {            
            string number = Console.ReadLine();     
            string digit = "" + number[1] + number[2] + number[3];
            string chars = "" + number[0] + number[4] + number[5];                        
            Permute(chars.ToCharArray(), 0, 2);
            List<string> huy = combination;
            combination = new List<string>();
            Permute(digit.ToCharArray(), 0, 2);
            List<string> huy_1 = combination;
            combination = new List<string>();            
            foreach (string chrs in huy)
            {
                foreach (string dgts in huy_1)
                {
                    combination.Add(Convert.ToString(chrs.First()+ dgts + chrs.Substring(1)));
                }
            }
            Console.WriteLine(combination.Count);
            foreach (string item in combination)
            {     
                
                Console.WriteLine(item);
            }
            
        }      
        static void Permute(char[] arry, int i, int n)
        {
            
            int j;
            if (i == n)
            {
                string chlen = "" ;
                foreach (char  c in arry)
                {
                    chlen += c;
                }  
                if(!combination.Contains(chlen)) {
                    combination.Add(chlen);
                }
               
            }
            else
            {
                for (j = i; j <= n; j++)
                {

                    Swap(ref arry[i], ref arry[j]);
                    Permute(arry, i + 1, n);
                    Swap(ref arry[i], ref arry[j]); //backtrack
                }
            }
        }

        static void Swap(ref char a, ref char b)
        {
            char tmp;
            tmp = a;
            a = b;
            b = tmp;
        }

    }
}