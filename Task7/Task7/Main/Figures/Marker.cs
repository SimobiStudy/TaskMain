using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;

namespace Task7.Main.Figures
{
    [IgnoreFigure]
    public class Marker : Square
    {
        public static readonly Size MarkerSize = new Size(5, 5);
    }
}
