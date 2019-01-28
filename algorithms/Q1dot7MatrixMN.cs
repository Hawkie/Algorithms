using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview1
{
    struct Coordinate
    {
        public Coordinate(int col, int row)
        {
            this.row = row;
            this.col = col;
        }
        public readonly int row;
        public readonly int col;
    }

    class Q1dot7MatrixMN
    {
        // mutates input image and returns with col and row zeros
        public int[,] ZeroMatrix(int[,] image)
        {
            var m = image.GetLength(0);
            var n = image.GetLength(1);
            var zeros = new List<Coordinate>();
            var cols = Enumerable.Range(0, m);
            var rows = Enumerable.Range(0, n);
            foreach (int row in rows)
            {
                foreach (int col in cols)
                {
                    if (image[col,row] == 0)
                    {
                        zeros.Add(new Coordinate(col, row));
                    }
                }
            }
            foreach (Coordinate c in zeros)
            {
                foreach(int row in rows)
                {
                    image[c.col, row] = 0;
                }
                foreach(int col in cols)
                {
                    image[col, c.row] = 0;
                }
            }
            return image;
        }

        public int[,] CreateImage(int size)
        {
            var image = Q1dot6Rotate.CreateImage(size);
            image[3, 4] = 0;
            return image;
        }

        [TestCase(10)]
        public void Test(int size)
        {
            var image = CreateImage(size);
            var zeroed = ZeroMatrix(image);
            Q1dot6Rotate.ConsoleImage(image, size);
        }
    }
}
