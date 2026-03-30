using System;
using System.Collections.Generic;
using System.Text;
using Task7;
using Task7.Main.Actions;
using Task7.Main.Figures;

namespace Task7.Main.Actions
{
    [Serializable]
    public class CreateNewFigureAction : IFigureAction
    {
        public CreateNewFigureActionData _data { get; set; }
        public void Execute()
        {
            var newFigure = _data.figure;
            _data.canvasInfo.ActiveFigures.Insert(0,newFigure);
        }

        public void Undo()
        {
            new DeleteFigureAction(_data.canvasInfo, _data.figure).Execute();
        }

        public CreateNewFigureAction(CanvasInfo canvasInfo, Figure figure)
        {
            CreateNewFigureActionData data = new CreateNewFigureActionData
            {
                canvasInfo = canvasInfo,
                figure = figure,
            };

            _data = data;
        }
    }
}

public class CreateNewFigureActionData
{
    public CanvasInfo canvasInfo = null!;
    public Figure figure { get; set; } = null!;

}
