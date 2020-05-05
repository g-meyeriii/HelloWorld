using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Box
    {
        // member variable
        private int length;
        private int height;
        //public int width;
        private int volume;
        private int area;

        public int Width { get; set; }

        public int Area {
            get {
                return this.length * Width;
            }
        }

        public int Volume {
            get {
                return this.length* this.Height* this.Width;
            }
        }


        public int Height 
        {
            get 
            {
                return height;
            }    
            set 
            {
                if(value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value; 
                }
            }

        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }

        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }
        
        public int GetLength()
        {
            return this.length;
        }
        
        
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height {1} and width {2} and volume ={3}",length,Height,Width,volume= length*Height*Width);
        }


    }
}
