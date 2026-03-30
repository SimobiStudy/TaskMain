using System;
using System.Collections.Generic;
using System.Text;
using Task7.Main.Figures;

namespace Task7.Main.Actions
{
    internal class ColorChangeAction : IFigureAction
    {
        private readonly ColorChangeActionData _data;
        public void Execute()
        {
            _data.FigureInAction.FigureColor = _data.NewColor;
        }

        public void Undo()
        {
            new ColorChangeAction(null, _data.OldColor.Value, _data.FigureInAction).Execute();
        }

        public ColorChangeAction(Color? oldColor, Color newColor, Figure figure)
        {
            ColorChangeActionData data = new ColorChangeActionData()
            {
                OldColor = oldColor,
                NewColor = newColor,
                FigureInAction = figure,
            };
            _data = data;
        }
    }

    public class ColorChangeActionData
    {
        public Color? OldColor;
        public Color NewColor;

        public Figure FigureInAction;
    }
}
