using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Task7.Main.Figures
{
    [Serializable]
    public class Square : Figure
    {
        public Square(Point location, Size size)
        {
            this.Location = location;
            this.Size = size;
        }

        public Square(){}

        protected override void DrawFunction(Graphics graphics, Brush brush, Rectangle _boundingBox)
        {
            graphics.FillRectangle(brush, _boundingBox);
        }

        public override object Clone()
        {
            var square = new Square()
            {
                FigureStroke = (Stroke)this.FigureStroke.Clone(),
                FigureColor = this.FigureColor,
                Location = this.Location,
                Size = this.Size
            };
            return square;
        }
    }
}
