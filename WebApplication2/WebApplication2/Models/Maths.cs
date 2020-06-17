using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Maths: InterfaceM
    {

        public int x { get; set; }
        public int y { get; set; }

        public Maths()
        {
            Random ran = new Random();
            x = ran.Next(0, 10);
            y = ran.Next(0, 10);
        }

        public int Add() { return x + y; }
        public int Sub() { return x - y; }
        public int Mult() { return x * y; }

        public int Div()
        {
            if (y == 0) { return 0; }
            else { return x / y; }
        }
    }

}
