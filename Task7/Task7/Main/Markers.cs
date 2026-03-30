using System;
using System.Collections.Generic;
using System.Text;
using Task7.Main.Figures;

namespace Task7.Main
{
    public class Markers : IDisposable
    {
        public List<Marker> markersList = new List<Marker>();

        
        public void AddMarkers(Graphics graphics, Figure figure)
        {
            markersList.Clear();
            for (int i = 0; i < 8; i++)
            {
                var marker = new Marker();
                marker.FigureColor = Color.White;
                markersList.Add(marker);
            }

            int left = figure.Location.X - Marker.MarkerSize.Width - (int)figure.FigureStroke.Width/2;
            int top = figure.Location.Y - Marker.MarkerSize.Height - (int)figure.FigureStroke.Width/2;
            int right = left + figure.Size.Width + Marker.MarkerSize.Width + (int)figure.FigureStroke.Width;
            int bottom = top + figure.Size.Height + Marker.MarkerSize.Height + (int)figure.FigureStroke.Width;
            int midX = left + figure.Size.Width / 2 + Marker.MarkerSize.Width/2 + (int)figure.FigureStroke.Width;
            int midY = top + figure.Size.Height / 2 + Marker.MarkerSize.Height/2 + (int)figure.FigureStroke.Width;

            // Верхний ряд
            markersList[(int)MarkerPosition.TopLeft].DrawFigure(graphics, new Point(left, top), Marker.MarkerSize);
            markersList[(int)MarkerPosition.TopCenter].DrawFigure(graphics, new Point(midX, top), Marker.MarkerSize);
            markersList[(int)MarkerPosition.TopRight].DrawFigure(graphics, new Point(right, top), Marker.MarkerSize);

            // Средний ряд
            markersList[(int)MarkerPosition.MiddleLeft].DrawFigure(graphics, new Point(left, midY), Marker.MarkerSize);
            markersList[(int)MarkerPosition.MiddleRight].DrawFigure(graphics, new Point(right, midY), Marker.MarkerSize);

            // Нижний ряд
            markersList[(int)MarkerPosition.BottomLeft].DrawFigure(graphics, new Point(left, bottom), Marker.MarkerSize);
            markersList[(int)MarkerPosition.BottomCenter].DrawFigure(graphics, new Point(midX, bottom ), Marker.MarkerSize);
            markersList[(int)MarkerPosition.BottomRight].DrawFigure(graphics, new Point(right, bottom ), Marker.MarkerSize);
        }

        public int MarkersHitTest(Point point)
        {
            for (int i = 0; i < markersList.Count; i++)
            {
                if (markersList[i].HitTest(point))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Dispose()
        {
            foreach (var marker in markersList)
            {
                marker.Dispose();
            }
        }

    public enum MarkerPosition
    {
        TopLeft = 0,
        TopCenter,
        TopRight,
        MiddleLeft,
        MiddleRight,
        BottomLeft,
        BottomCenter,
        BottomRight
        }
    }
}
