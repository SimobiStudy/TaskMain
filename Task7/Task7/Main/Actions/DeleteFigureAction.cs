using System;
using System.Collections.Generic;
using System.Text;
using Task7;
using Task7.Main.Figures;

namespace Task7.Main.Actions
{
    public class DeleteFigureAction : IFigureAction
    {
        public DeleteFigureActionData _data { get; set; }
        public void Execute()
        {
            _data.CanvasInfoInAction.ActiveFigures.Remove(_data.FigureInAction);
        }

        public void Undo()
        {
            new CreateNewFigureAction(_data.CanvasInfoInAction, _data.FigureInAction);
        }

        public DeleteFigureAction(CanvasInfo canvasInfo, Figure figure)
        {
            DeleteFigureActionData data = new DeleteFigureActionData()
            {
                CanvasInfoInAction = canvasInfo,
                FigureInAction = figure,
            };

            _data = data;
        }
    }
}

public class DeleteFigureActionData
{
    public CanvasInfo CanvasInfoInAction = null!;
    public Figure FigureInAction { get; set; } = null!;

}

