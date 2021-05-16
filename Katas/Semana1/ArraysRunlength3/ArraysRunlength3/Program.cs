using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysRunlength3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] in1 = { 1, 2, 3, 4, 4, 4, 5, 6 };
            string res = Enco(in1);
            Console.WriteLine(res);
            int[] out1 = Decod(res); 
            foreach (int i in out1){
                Console.WriteLine(i); 
            }
        }

        static string Enco(int[] arr)
        {
            string number = "";
            if (arr[0] != arr[1])
            {
                number += (arr[0]).ToString() + ".";
            }

            int i = 0;
            while (i < arr.Length - 1)
            {
                int contador = 1; 
                while(arr[i] == arr[i + 1])
                {
                    contador += 1;
                    i++;
                }

                if(contador != 1)
                {
                    number += (arr[i]).ToString() + "*" + (contador).ToString() + "."; 
                }
                i++;
            }

            number += (arr.Last()).ToString();
            return number; 
        }

        static int[] Decod(string numbers)
        {
            List<int> nums_temp = new List<int>();
            string[] numstr = numbers.Split('.');
            int[] numbers_arr;

            int i = int.Parse(numstr[0]); 
            while(i <= int.Parse(numstr.Last()))
            {
                nums_temp.Add(i);
                i++; 
            }

            foreach(string n in numstr)
            {
                if (n.Contains("*"))
                {
                    string[] temp = n.Split("*");
                    int num = int.Parse(temp[0]);
                    int multipli = int.Parse(temp[1]);
                    int ind = nums_temp.IndexOf(num);

                    int t = 1; 
                    while(t < multipli)
                    {
                        nums_temp.Insert(ind, num);
                        t++; 
                    }
                }
            }

            return numbers_arr = nums_temp.ToArray(); 


        }
    }
}
