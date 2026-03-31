using System;
using System.Collections.Generic;
using System.Text;

namespace Task7.Main.Figures
{
    internal class SquareWithHole : Square
    {
        public SquareWithHole() {}
        public SquareWithHole(Point location, Size size) : base(location, size)
        { }

        protected override void DrawFunction(Graphics graphics, Brush brush, Rectangle _boundingBox)
        {
            // Рисуем внешний квадрат
            graphics.FillRectangle(brush, _boundingBox);
         

            int holeX = _boundingBox.X ;
            int holeY = _boundingBox.Y ;
            Rectangle holeRect = new Rectangle(new Point(holeX, holeY), new Size(_boundingBox.Width, _boundingBox.Height));
            using Brush holeBrush = new SolidBrush(Color.White); // Цвет дырки (можно изменить)
            graphics.FillEllipse(holeBrush, holeRect);
        }

        public override object Clone()
        {
            var square = new SquareWithHole()
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