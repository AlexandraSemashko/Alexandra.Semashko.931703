using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class PodMaths: IPodMaths
    {
        public InterfaceM tec { get; set; }
        public InterfaceM Nov()
        { tec = new Maths(); return tec; }
    }
}
