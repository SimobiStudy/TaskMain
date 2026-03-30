using System;
using System.Collections.Generic;
using System.Text;
using Task7.Main.Actions;

namespace Task7.Main
{
    [Serializable]
    public class PreviousActionsStorer
    {
        public readonly Stack<IFigureAction> _list = new Stack<IFigureAction>();

        public PreviousActionsStorer(int depth)
        {
            if (depth < 1)
                depth = 1;
            _list.TrimExcess(depth);
        }
        public void Clear()
        {
            _list.Clear();
        }

        public int Count
        {
            get { return (_list.Count); }
        }

    }
}
