using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Color
    {
        //Propriedades auto-implementadas, não têm variável de suporte
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }

        // Property pattern num switch
        public string Name => this switch
        {
            { Red: 255, Green: 0, Blue: 0, Alpha: 255 } => "Red 100%",
            { Red: 0, Green: 255, Blue: 0, Alpha: 255 } => "Green 100%",
            { Red: 0, Green: 0, Blue: 255, Alpha: 255 } => "Blue 100%",
            _ => "Mixed",
        };

        // Construtor que aceita todos os parâmetros
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        // Construtor que mete alpha = 255 e aceita o resto dos parâmetros
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        // Propriedade só de leitura por ser apenas um Getter
        public byte Gray => (byte)((Red + Green + Blue) / 3);
    }
}