using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCompression
{
    public class Image
    {
        private Pixel[,] _pixels;

        public Pixel this[int x, int y]
        {
            get { return _pixels[x, y]; }
        }
    }
}
