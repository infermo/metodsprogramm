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
            List<string> combchrs = combination;
            combination = new List<string>();
            Permute(digit.ToCharArray(), 0, 2);
            List<string> combdgts = combination;
            combination = new List<string>();            
            foreach (string chrs in combchrs)
            {
                foreach (string dgts in combdgts)
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
                string chrss = "" ;
                foreach (char  c in arry)
                {
                    chrss += c;
                }  
                if(!combination.Contains(chrss)) {
                    combination.Add(chrss);
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