using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    internal class RealTimeExample
    {
        static void Main(string[] args)
        {
            Task task=new Task(CallMethod);
            task.Start();
            task.Wait();
            Console.ReadLine();
        }

        static async  void CallMethod()
        {
            string filepath = @"E:\Sulakshana\StudyMaterial\AzureDockerSpecflow\AzureFunctions.docx";
            Task<int> task=ReadFile(filepath);
            work1();
            work2();
            work3();
            int fileLength = await task;
            Console.WriteLine(fileLength);
            work3();
            work2();

        }

        static void work1()
        {
            Console.WriteLine("Doing some other work1");

        }



        static void work2()
        {
            Console.WriteLine("Doing some other work2");

        }


        static void work3()
        {
            Console.WriteLine("Doing some other work3");

        }

        static async Task<int> ReadFile(string path) 
        {

            int len = 0;
            Console.WriteLine("Now started reading file.....");

            using (StreamReader sr=new StreamReader(path))
            {
                string s=await sr.ReadToEndAsync();
                len = s.Length;
            }
            Console.WriteLine("Now completed  reading file.....");
            return len; 
        }


    }
}
