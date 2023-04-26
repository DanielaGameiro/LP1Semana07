using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color green = new Color(0, 255, 0);
            Color white = new Color(255, 255, 255);

            Sphere bigGreen = new Sphere(green, 5);
            Sphere littleWhite = new Sphere(white, 2);

            Console.WriteLine(
                $"Verde: {green.GetRed()}, {green.GetGreen()}, {green.GetBlue()}, {green.GetGray()}");

            bigGreen.Throw();
            bigGreen.Throw();
            bigGreen.Throw();
            Console.WriteLine(
                $"Esfera verde foi atirada {bigGreen.GetTimesThrown()}x");

            bigGreen.Throw();
            bigGreen.Throw();
            Console.WriteLine(
                $"Esfera verde foi atirada {bigGreen.GetTimesThrown()}x");

            littleWhite.Throw();
            littleWhite.Throw();
            Console.WriteLine(
                $"Esfera branca foi atirada {littleWhite.GetTimesThrown()}x");

            // Como foi furada não vai ser atirada mais vezes, vai imprimir o valor antigo (2x)
            littleWhite.Pop();
            littleWhite.Throw();
            littleWhite.Throw();
            littleWhite.Throw();
            Console.WriteLine(
                $"Esfera branca foi atirada {littleWhite.GetTimesThrown()}x");
        }
    }
}
