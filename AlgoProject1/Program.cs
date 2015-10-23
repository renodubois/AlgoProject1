using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProject1
{
    class Program
    {
        static void randomString(int length, char[] output)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new Random();

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = chars[random.Next(chars.Length)];
            }
        }

        public struct similarPairs
        {
            public int p1, p2;

            public similarPairs(int pair1, int pair2)
            {
                p1 = pair1;
                p2 = pair2;
            }

        }


        static void compareReviews(char[] r1, char[] r2, similarPairs[] results, int currentResultIndex)
        {

        }



        static void Main(string[] args)
        {
            // Dynamic Programming Approach for the LCS problem.
            // Implemented in C#


            /*
            Description: Takes 2 strings, first checks beginning and end for common letters, adds them to the final sequence,
            then removes them. Next uses a 2D array to record possible subsequences. Takes longest length of these, then calculates
            similarity index using that info. Scans through a whole directory to do this.
            */

            // Part 1: Random Dataset
            // Part a: Same length
            Console.WriteLine("Random Dataset: Same Length");


            Random rnd = new Random();
            int[] stringLength = new int[10];

            Console.WriteLine("Initilizing arrays...");

            char[][] stringSet1 = new char[100][];
            char[][] stringSet2 = new char[100][];
            char[][] stringSet3 = new char[100][];
            char[][] stringSet4 = new char[100][];
            char[][] stringSet5 = new char[100][];
            char[][] stringSet6 = new char[100][];
            char[][] stringSet7 = new char[100][];
            char[][] stringSet8 = new char[100][];
            char[][] stringSet9 = new char[100][];
            char[][] stringSet10 = new char[100][];

            Console.WriteLine("Done!");

            Console.WriteLine("Creating random strings...");

            // Length of Strings: Array containing 10 lengths, varying from 10-1000.
            for (int i = 0;i < 10;i++)
            {
                stringLength[i] = rnd.Next(10, 1001);
            }

            // Prints the length array, for testing only.
            foreach(var item in stringLength)
            {
                Console.WriteLine(item.ToString());
            }

            // Create 100 strings of length stringLength[0]
            for (int i = 0; i < 100; i++)
            {
                stringSet1[i] = new char[stringLength[0]];
                randomString(stringLength[0], stringSet1[i]);
            }   

            // Create 100 strings of length stringLength[1]
            for (int i = 0; i < 100; i++)
            {
                stringSet2[i] = new char[stringLength[1]];
                randomString(stringLength[1], stringSet2[i]);
            }
            // Create 100 strings of length stringLength[2]
            for (int i = 0; i < 100; i++)
            {
                stringSet3[i] = new char[stringLength[2]];
                randomString(stringLength[2], stringSet3[i]);
            }
            // Create 100 strings of length stringLength[3]
            for (int i = 0; i < 100; i++)
            {
                stringSet4[i] = new char[stringLength[3]];
                randomString(stringLength[3], stringSet4[i]);
            }
            // Create 100 strings of length stringLength[4]
            for (int i = 0; i < 100; i++)
            {
                stringSet5[i] = new char[stringLength[4]];
                randomString(stringLength[4], stringSet5[i]);
            }
            // Create 100 strings of length stringLength[5]
            for (int i = 0; i < 100; i++)
            {
                stringSet6[i] = new char[stringLength[5]];
                randomString(stringLength[5], stringSet6[i]);
            }
            // Create 100 strings of length stringLength[6]
            for (int i = 0; i < 100; i++)
            {
                stringSet7[i] = new char[stringLength[6]];
                randomString(stringLength[6], stringSet7[i]);
            }
            // Create 100 strings of length stringLength[7]
            for (int i = 0; i < 100; i++)
            {
                stringSet8[i] = new char[stringLength[7]];
                randomString(stringLength[7], stringSet8[i]);
            }
            // Create 100 strings of length stringLength[8]
            for (int i = 0; i < 100; i++)
            {
                stringSet9[i] = new char[stringLength[8]];
                randomString(stringLength[8], stringSet9[i]);
            }
            // Create 100 strings of length stringLength[9]
            for (int i = 0; i < 100; i++)
            {
                stringSet10[i] = new char[stringLength[9]];
                randomString(stringLength[9], stringSet10[i]);
            }

            Console.WriteLine("Done!");

            // Run algorithim for each stringset. Returns Review Pairs with a score of 0.7 or above to an array.



            // Waits for an input to close the Terminal Window.
            Console.ReadKey();
        }

        private static void randomString(int v1, char v2)
        {
            throw new NotImplementedException();
        }
    }
}
