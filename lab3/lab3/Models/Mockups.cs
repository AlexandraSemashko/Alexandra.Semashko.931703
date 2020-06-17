using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Models
{
    [RightAns]
    public class Mockups
    {
        public int x { get; set; }
        public int y { get; set; }
        public int oper { get; set; }
        public int ans { get; set; }

        public Mockups()
        {

        }

        public Mockups(bool a)
        {
            Random ran = new Random();
            x = ran.Next(0, 10);
            y = ran.Next(0, 10);
            oper = ran.Next(0, 3);
        }

        public int DoOper()
        {
            switch (oper)
            {
                case 0: return Add();
                case 1: return Sub();
                case 2: return Mult();
                case 3: return Div();
                default: return 0;
            }
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

    public class RightAns : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Mockups cl = value as Mockups;

            if (cl.ans == cl.DoOper()) { return true; }

            return false;
        }
    }
}
