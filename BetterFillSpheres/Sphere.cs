using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Sphere
    {
        // Variáveis
        private float radius;

        // Propriedades auto-implementadas 
        public Color Color { get; }
        public int TimesThrown { get; private set; }

        // Construtor
        public Sphere(Color color, float radius)
        {
            this.radius = radius;
            Color = color;
            TimesThrown = 0;
        }

        // Método Pop(), não pede para devolver nada (void)
        public void Pop()
        {
            radius = 0;
        }

        // Método Throw(), não pede para devolver nada (void)
        public void Throw()
        {
            if (radius > 0)
            {
                TimesThrown++;
            }
        }
    }
}