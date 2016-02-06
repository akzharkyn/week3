using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace _2exercise
{
    class Program     //2week 2nd exercise 1st method
    {
        static void Main(string[] args)
        {
            StreamReader inFile= new StreamReader(@"C:\Users\ASUS\Desktop\каз яз\input.txt"); //открывает файл инпут и читает
            //using (StreamWriter outFile = new StreamWriter("output.txt")) //вывести на другой созданный файл
            string ss;
            int maxx = -1000000;
            int minn = 10000000;
            while ((ss=inFile.ReadLine())!=null)    //передает каждую строку в стринг и пока файл не пустой
            {
               
                int a = int.Parse(ss);  //берет первое значение и парсит
                if (maxx < a) maxx = a;
                if (minn > a) minn = a;


            }
            Console.WriteLine("максимум число" + " " + maxx);
            Console.WriteLine("минимум число" + " " + minn);
            Console.ReadKey();


                
            

        }
    }
}
