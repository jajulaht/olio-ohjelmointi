﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktiivisuus
{
    class Square : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("Draw square!");
        }
    }
}
