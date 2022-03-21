using System;
using System.Collections.Generic;
using System.Text;

namespace Abstarct__polymorphism.Models
{
     class Rectangular :Figure
    {
        private int width;
        private int lenght;

        public int Width 
        {
            get 
            { 
                return width;
            } 
            set 
            {
                if (value > 0)
                {
                    width = value;
                } 
            }
        }
        public int Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                if (value > 0)
                {
                    lenght = value;
                }
            }
        }
        public Rectangular(int width, int lenght)
        {
            this.width = width;
            this.lenght = lenght;
        }

        public override int CalcArea()
        {
            return (width * lenght);
        }

        
    }
}
