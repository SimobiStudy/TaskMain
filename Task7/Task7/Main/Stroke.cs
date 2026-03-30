using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;

namespace Task7.Main
{
    [Serializable]
    public class Stroke : ICloneable
    {
        /// <summary>
        /// Конструктор без параметров, со свойствами по умолчанию
        /// </summary>
        public Stroke()
        {
            Color = Color.Black;
            Width = 1f;
        }


        /// <summary>
        /// Цвет линии фигуры
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Ширина линии фигуры
        /// </summary>
        public float Width { get; set; }

        /// <summary>
        /// Стиль линии фигуры
        /// </summary>
        public DashStyle DashStyle { get; set; }

        /// <summary>
        /// Свойство возвращает "карандаш", настроенный по текущим свойствам 
        /// </summary>
        public Pen UpdatePen(Pen pen)
        {
            if (pen == null)
                throw new ArgumentNullException();
            
            return pen;
        }

        public void DrawStroke(Graphics graphics, Rectangle boundingBox)
        {
            using Pen strokePen = new Pen(Color.FromArgb(Color.A, Color), Width);
            strokePen.DashStyle = DashStyle;
            graphics.DrawRectangle(strokePen, boundingBox);
        }

        public object Clone()
        {
            var newStroke = new Stroke
            {
                Color = this.Color,
                Width = this.Width,
                DashStyle = this.DashStyle
            };
            return newStroke;
        }
        
    }

}
