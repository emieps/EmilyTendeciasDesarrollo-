using System;

namespace ArrayRunLength2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pru = { 1, 2, 3, 4, 4, 4, 5, 6 };
            string resul = Encod(pru);
            Console.WriteLine(resul);
        }

        static string Encod(int[] input)
        {
            string number = ""; 

            if(input[0] != input[1])
            {
                number += (input[0]).ToString() + '.'; 
            }

            int inpu_len = input.Length;

            for(int i = 0; i < inpu_len - 1; i++)
            {
                int repe = 1; 
                while(input[i] == input[i + 1])
                {
                    repe++;
                    i++; 
                }

                if(repe != 1)
                {
                    number += (input[i]).ToString() + '*' + (repe).ToString() + '.'; 
                }
            }
            number += (input[inpu_len - 1]).ToString();

            return number; 
        }
    }
}
