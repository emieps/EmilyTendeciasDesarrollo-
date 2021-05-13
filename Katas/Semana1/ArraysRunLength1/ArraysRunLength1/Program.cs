using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ArraysRunLength1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pru = { 1, 2, 2, 3, 4, 4, 4, 5, 6 };
            string resul = Encoding(pru);
            Console.WriteLine(resul);
            int[] des = Decoding(resul);
            foreach(int i in des)
            {
                Console.WriteLine(i); 
            }

        }

        static string Encoding(int[] arr)
        {
            string num = ""; 

            if(arr[0] != arr[1])
            {
                num += (arr[0]).ToString() + ".";
            }

            for(int j = 0; j < arr.Length - 1; j++)
            {
                int count = 1; 
                while(arr[j] == arr[j + 1])
                {
                    count ++;
                    j++;  
                }

                if (count == 1)
                { }
                else
                {
                    num += "." + (arr[j]).ToString() + "*" + (count).ToString() + ".";
                }
                
            }

            num += "." + (arr.Last()).ToString();

            return num;
        }

        static int[] Decoding(string srt)
        {
            int[] num;
            string[] num_str = srt.Split(".");
            List<int> numbers = new List<int>();

            int i = int.Parse(num_str[0]); 
            while(i <= int.Parse(num_str.Last()))
            {
                numbers.Add(i);
                i++; 
            }

            foreach(string word in num_str)
            {
                if(word.Contains('*') == true)
                {
                    string[] temp = Regex.Split(word, @"\D+");
                    int numbe = int.Parse(temp[0]);
                    int mult = int.Parse(temp[1]);
                    int index = numbers.IndexOf(numbe); 

                    for(int t = 1;  t < mult; t++)
                    {
                        numbers.Insert(index, numbe); 
                    }

                }
            }

            num = numbers.ToArray(); 

            return num;

        }
       
    }
}
