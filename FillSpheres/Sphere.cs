using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Sphere
    {
        // Variáveis
        private readonly Color color;
        private float radius;
        private int timesThrown;

        // Construtor
        public Sphere(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            timesThrown = 0;
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
                timesThrown++;
            }
        }

        // Método Getter que retorna o nº de vezes que foi atirada
        public int GetTimesThrown() => timesThrown;
    }
}