using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Task8.Types;

namespace Task8
{
    public partial class GameInfo : UserControl
    {
        private GameInfo()
        {
            InitializeComponent();
        }

        public GameInfo(Game game) : this()
        {
            if (game == null) throw new ArgumentNullException(nameof(game));

            labelGame.Text = $"{game.Name}";
            labelDiff.Text = game.PlayedDifficulty;


            labelResult.Text = game.IsWon ? "Победа" : "Поражение";
            labelResult.ForeColor = game.IsWon ? Color.Green : Color.Red;

            if (game.IsWon && game.TimeTaken > 0)
                labelTimer.Text = TimeSpan.FromSeconds(game.TimeTaken).ToString(@"mm\:ss");
            else
                labelTimer.Visible = false;

            if (Difficulty.Difficulties.Any(x => x.Name == game.PlayedDifficulty))
            {
                var find = Difficulty.Difficulties.Find(x => x.Name == game.PlayedDifficulty);
                labelDiff.ForeColor = find.DiffColor;
            }
        }
    }
}
