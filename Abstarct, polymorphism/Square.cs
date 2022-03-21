using System;
using System.Collections.Generic;
using System.Text;

namespace Abstarct__polymorphism.Models
{
     class Square : Figure
    {
        private int side;
        
        public int Side
        {
            get
            {
                return side;
            }
            set 
            {
                if (value > 0)
                {
                    side = value;
                }
            }
            
        }
        public Square(int side)
        {
            this.side = side;
        }

        public override int CalcArea()
        {
            return side * side;
        }
    }
}
