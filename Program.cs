﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
//        enum students { furqan=1, fu=11/5,dswd,sded,dsdedsdsd,eded,edw=2, jhbj,jhb}
        static void Main(string[] args)
        {
            int s = 2;
            var array = new int[10];
            
            Console.WriteLine(array.Length);
            Console.WriteLine("0");
            array[0] = 1;
            array[1] = 1;

            for (int i = 0; i < array.Length-2 ; i++,s++)
            {
                array[s] += array[i] + array[i+1];
            }
            foreach (var VARIABLE in array)
            {
                Console.WriteLine(VARIABLE);
                
            }
           




















//            Console.WriteLine("Enter How many Rows you want ");
//            var inp = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine();
//            var col = 2 * inp;
//            col--;
//            var maxC = inp + 1;
//            var maxCr = maxC -1;
//            var maxCl = maxC +1;
//            for (int r = 0; r < inp ; r++, maxCr++, maxCl--)
//            {
//                for (int c= 0; c < col; c++)
//                {
//                    if (c == maxC ||(c< maxCr && c> maxCl))
//                    {
//                        if (r==0||r==1)
//                        {
//                            break;
//                        }Console.Write("*");
//                        
//                    }
//                    else
//                    {
//                        Console.Write(" ");
//                    }
//                }
//                Console.WriteLine();
//            }

//            for (int i = 0; i <=  inp; i++)
//            {
//                for (int j = 0; j <=((2*inp)-1) ; j++,c++)
//                {
//                    if (j<=inp && (j>= (4-c)))
//                    {
//                        Console.Write("*");
//                    }
//                    else
//                    {
//                        Console.Write(" ");
//                    }
//                }    
//                 Console.WriteLine(" ");
//           }

        }

        
    }
}
