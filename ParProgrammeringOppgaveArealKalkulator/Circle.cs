using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringOppgaveArealKalkulator
{
    internal class Circle : Shape, ICalculateArea
    {
        public int Radius { get; set; }
        public Circle(string name, int radius)
        {
            Name = name;
            Radius = radius;
        }

        void ICalculateArea()
        {
        }
    }
}
