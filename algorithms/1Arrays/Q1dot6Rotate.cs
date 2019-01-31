using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview1
{
    class Q1dot6Rotate
    {
        // mutating method :(
        public int[,] Rotate(int[,] image, int size)
        {
            int N = size -1;
            for (int y=0; y<= size/2; y++)
            {
                for (int x=y; x<size-y-1; x++)
                {
                    var v1 = image[x, y];
                    var v2 = image[N - y, x];
                    var v3 = image[N - x, N - y];
                    var v4 = image[y, N - x];

                    image[N - y, x] = v1;
                    image[N - x, N - y] = v2;
                    image[y, N - x] = v3;
                    image[x, y] = v4;
                }
            }
            return image;
        }

        public static int[,] CreateImage(int size)
        {
            int[,] image = new int[size, size];
            var xs = Enumerable.Range(0, size);
            var ys = Enumerable.Range(0, size);
            foreach (int y in ys)
            {
                foreach (int x in xs)
                {
                    image[x, y] = x + (y*10);
                }
            }
            return image;
        }

        public static void ConsoleImage(int[,] image, int size)
        {
            var xs = Enumerable.Range(0, size);
            var ys = Enumerable.Range(0, size);
            foreach (int y in ys)
            {
                foreach (int x in xs)
                {
                    Console.Write(string.Format("{0:000},", image[x, y]));
                }
                Console.WriteLine();
            }
        }

        [TestCase(10)]
        [TestCase(13)]
        public void RotateTest(int size)
        {
            var image = CreateImage(size);
            ConsoleImage(image, size);
            Console.WriteLine();
            var rotated = Rotate(image, size);
            ConsoleImage(rotated, size);
            
        }
    }
}
