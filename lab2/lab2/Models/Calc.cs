using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2.Models
{
    public class Calc
    {
        public float x { get; set; }
        public float y { get; set; }

        public Calc()
        {
            Random ran = new Random();
            x = ran.Next(0, 10);
            y = ran.Next(0, 10);
        }

        public float Add() { return x + y; }
        public float Sub() { return x - y; }
        public float Mult() { return x * y; }

        public float Div()
        {
            if (y == 0) { return 0 ; }
            else { return x / y; }
        }
    }
}
