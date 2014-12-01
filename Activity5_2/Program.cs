using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5_2
{
    class Program
        {
            static List<int> numList = new List<int>();
            static void Main(string[] args)
            {
                LoadList(10);
                foreach (int i in numList)
                {
                System.Console.WriteLine(i);
                }
                Console.ReadLine();
            }
            static void LoadList(int imax);
            {       
                for (int i = 1; i <= 10; 1++)
                {
                    numList.Add(i);
                }
            }
        }
