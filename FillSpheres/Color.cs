using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Color
    {
        //Variáveis
        private byte red, green, blue, alpha;

        // Construtor que aceita todos os parâmetros
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        // Construtor que mete alpha = 255 e aceita o resto dos parâmetros
        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }

        // Métodos Getters
        public byte GetRed() => red;
        public byte GetGreen() => green;
        public byte GetBlue() => blue;
        public byte GetAlpha() => alpha;

        // Método Setters
        public void SetRed(byte red)
        {
            this.red = red;
        }

        public void SetGreen(byte green)
        {
            this.green = green;
        }

        public void SetBlue(byte blue)
        {
            this.blue = blue;
        }

        public void SetAlpha(byte alpha)
        {
            this.alpha = alpha;
        }

        // Método Getter para o grau de cinzento
        // Converter o int (3) em byte
        public byte GetGray() => (byte)((red + green + blue) / 3);
    }
}