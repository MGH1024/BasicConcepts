using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.NotFollowingLSP.Is_A
{
    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public virtual int CalculateArea()
        {
            return Height * Width;
        }

    }

    public class Square:Rectangle
    {
        private int _height;
        private int _width;


        public override int Width
        {
            get { return _width; }
            set
            {
                _height = value;
                _width = value;
            }
        }

        public override int Height
        {
            get { return _height; }
            set
            {
                _height = value;
                _width = value;
            }
        }

        public override int CalculateArea()
        {
            return Height*Height;
            // or return Width*Width;
        }
    }
}
