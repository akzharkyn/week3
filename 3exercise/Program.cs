using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _3exercise
{
    class Program
    {
        static bool findPrime(int p)
        {
            int cnt = 0;

            for(int i=2;i<Math.Sqrt(p);i++)
            {
                if(p%i==0) { cnt++; }

            }
            return cnt==0 && p != 1;

        }
        static void Main(string[] args)
        {
            StreamReader inFile = new StreamReader(@"C:\Users\ASUS\Desktop\каз яз\numbers.txt");
            using(StreamWriter outFile=new StreamWriter("minprime.txt"))
            {
                string lines = inFile.ReadLine();
                string[] line = lines.Split(',');
                var linetoa = new List<int>(); //list intov 
                var atob = new List<int>();  //sostoit tolko iz intov perev so stringa

                for(int i=0;i<line.Length;i++)
                {
                    linetoa.Add(int.Parse(line[i]));

                    if(findPrime(linetoa[i])== true)
                    {
                        atob.Add(linetoa[i]); //zdes hranitsya uje prostye 4isla
                    }

                }
                int min = atob[0];
                foreach(int i in atob)  //berem kajdyi chlen massiva
                {
                    if(i<min) { min = i; }
                   

                }
                outFile.WriteLine("минимум простое число это" +" " +min);
                




                
                    }
                
                

               

               
                }
            }
       }
    
