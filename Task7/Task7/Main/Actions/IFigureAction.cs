using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Task7.Main.Actions
{
    public interface IFigureAction
    {
        public void Execute();

        public void Undo();
    }
}
