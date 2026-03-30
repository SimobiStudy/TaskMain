using System;
using System.Collections.Generic;
using System.Text;
using Task7;
using Task7.Main.Figures;

namespace Task7.Main.Actions
{
    public class MoveFigureAction : IFigureAction
    {
        private MoveFigureActionData _data { get; set; }

        public void Execute()
        {
            _data.FigureInAction.Location = _data.NewLocation;
        }

        public void Undo()
        {
            if (_data.OldLocation == null)
            {
                return;
            }
            new MoveFigureAction(null, _data.OldLocation.Value, _data.FigureInAction).Execute();
        }

        public MoveFigureAction(Point? oldLocation, Point newLocation, Figure figure)
        {
            MoveFigureActionData data = new MoveFigureActionData()
            {
                OldLocation = oldLocation,
                NewLocation = newLocation,
                FigureInAction = figure,
            };
            _data = data;
        }
    }
}

public class MoveFigureActionData
{
    public Point? OldLocation { get; set; }

    public Point NewLocation { get; set; }
    public Figure FigureInAction { get; set; } = null!;

}

