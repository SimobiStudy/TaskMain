using System;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace Task7.Main.Figures
{
    public abstract class Figure : IDisposable, ICloneable
    {
        public Color FigureColor { get; set; } = Color.Fuchsia;

        public Stroke FigureStroke { get; set; } = new Stroke();

        public Point Location
        {
            get
            {
                return _savedBoundingBox.Location;
            }

            set
            {
                if (_savedBoundingBox == null)
                    _savedBoundingBox = new Rectangle(value, new Size(5,5));

                _savedBoundingBox.Location = value;
            }
        }

        public Size Size
        {
            get
            {

                return _savedBoundingBox.Size;
            }
            set
            {
                if (_savedBoundingBox == null)
                    _savedBoundingBox = new Rectangle(new Point(0, 0), value);

                _savedBoundingBox.Size = value;
            }
        }

        private Rectangle _savedBoundingBox;

        public virtual void ResizeFigure(Size newSize)
        {
            _savedBoundingBox.Size = newSize;
        }

        protected abstract void DrawFunction(Graphics graphics, Brush brush, Rectangle _boundingBox);
        public virtual void DrawFigure(Graphics graphics, Rectangle _boundingBox)
        {
            _savedBoundingBox = _boundingBox;

            using Brush brush = new SolidBrush(FigureColor);

            DrawFunction(graphics, brush, _boundingBox);
            FigureStroke.DrawStroke(graphics, _boundingBox);
        }

        public virtual void DrawFigure(Graphics graphics, Point location, Size size)
        {
            var boundingBox = new Rectangle(location, size);

            DrawFigure(graphics, boundingBox);
        }


        public virtual void MoveFigure(int x, int y)
        {
            _savedBoundingBox.X += x;
            _savedBoundingBox.Y += y;
        }

        public virtual void MoveFigureToPoint(Point point)
        {
            _savedBoundingBox.X = point.X;
            _savedBoundingBox.Y = point.Y;
        }

        public virtual void MoveFigureToPointCentered(Point point)
        {
            _savedBoundingBox.X = point.X - (_savedBoundingBox.Width/2);
            _savedBoundingBox.Y = point.Y - (_savedBoundingBox.Width/2);
        }

        public virtual bool HitTest(Point mousePoint)
        {
            Rectangle rect = new Rectangle(Location, Size);
            return rect.Contains(mousePoint);
        }

        public bool isDisposed { get; private set; }
        public void Dispose()
        {
            isDisposed = true;
        }


        protected Figure() {}

        protected Figure(Point location, Size size)
        {
            Location = location;
            Size = size;
        }
        public abstract object Clone();
    }
}

[System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
public class IgnoreFigure : System.Attribute
{

    public IgnoreFigure()
    { }
}