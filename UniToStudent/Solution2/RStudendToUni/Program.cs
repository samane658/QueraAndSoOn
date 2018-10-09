using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RStudendToUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 1;
            int n = 10;

            int[,] students = new int[,]{
                                            {8,4,3,2,5,9,7,6,1,10},{10,8,9,7,6,5,4,3,2,5},{1,4,3,7,8,6,9,10,2,5},{6,8,9,10,7,2,3,5,4,1},{1,5,2,9,7,10,8,6,3,4}
                                            , {1,4,3,2,5,9,7,6,8,10},{10,8,9,7,6,5,4,3,2,5},{1,4,3,7,8,6,9,10,2,5},{6,8,9,10,7,2,3,5,4,1},{1,5,2,9,7,10,8,6,3,4}

                                           };
            int[] universities = new int[n];
            int[] choice = new int[n];
            int currentUni = n;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int t=1;t<=test;t++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($" Student {i+1} Choose this Universities : ");
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write(students[i, k]);

                        // students[i, k] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();
                }


                    for (int i = 0; i < n; i++)
                      universities[i] = i + 1;

           
                Console.WriteLine();

                for (int s=1;s<=n;s++)
                {
                    for(int u=1;u<=n;u++)
                    {
                        int isexist = 0;
                        int e;
                        for (e = 1; e <= currentUni; e++)
                            if (students[s - 1, u - 1] == universities[e - 1])
                            {
                                isexist = 1;
                                break;
                            }

                            if(isexist==1)
                            {
                            choice[s - 1] = students[s - 1, u - 1];
                            if(e !=currentUni)
                             universities[e-1] = universities[currentUni - 1];

                           /* for (int p = 0; p < currentUni; p++)
                                Console.WriteLine(universities[p]);*/
                            currentUni--;
                            break;
                            }

                    }
                }

                sw.Stop();
                for(int j=0;j<n;j++)
                    Console.WriteLine($"students {j+1} : Ini {choice[j]} ");

                


            }

            Console.WriteLine($"Time : {sw.Elapsed}");

            Console.ReadLine();

        }
    }
}
