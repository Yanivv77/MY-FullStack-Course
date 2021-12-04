using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Diamond
    {

        public static void Diamondd(int size)
        {
            Pyramid.Pyramidd(size);
            Pyramid.ReversePyramid(size);

        }
    }
}
