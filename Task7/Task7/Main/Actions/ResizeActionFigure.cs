using System;
using System.Collections.Generic;
using System.Text;
using Task7.Main.Figures;

namespace Task7.Main.Actions
{
    public class ResizeActionFigure : IFigureAction
    {
        private ResizeActionFigureData _data { get; set; }

        public void Execute()
        {
            _data.FigureInAction.MoveFigureToPoint(_data.NewLocation);
            _data.FigureInAction.ResizeFigure(_data.NewSize);
        }

        public void Undo()
        {
            new ResizeActionFigure(null, _data.OldSize.Value, null, _data.OldLocation.Value, _data.FigureInAction).Execute();
        }

        public ResizeActionFigure(Size? oldSize, Size newSize, Point? oldPosition, Point newPosition, Figure figure)
        {
            ResizeActionFigureData data = new ResizeActionFigureData()
            {
                OldSize = oldSize,
                NewSize = newSize,
                OldLocation = oldPosition,
                NewLocation = newPosition,
                FigureInAction = figure,
            };
            _data = data;
        }
    }
}


public class ResizeActionFigureData
{
    public Size? OldSize { get; set; }

    public Point? OldLocation { get; set; }
    public Point NewLocation { get; set; }

    public Size NewSize { get; set; }
    public Figure FigureInAction { get; set; } = null!;

}