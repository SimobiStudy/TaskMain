using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SupabaseReg;

namespace Task8
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();

            UpdateStandardComboBoxItems();
            comboBoxSelection.Items.Clear();
            comboBoxSelection.Items.AddRange(standartComboBoxItems.ToArray());
            comboBoxSelection.SelectedIndex = 0;
        }

        private async void DrawGames()
        {
            flowLayoutPanelGames.Controls.Clear();
            var games = await GameGetterHelper.GetGameList((comboBoxSelection.SelectedItem as ComboBoxSelection)?.Selector ?? "All");
            foreach (var game in games)
            {
                flowLayoutPanelGames.Controls.Add(new GameInfo(game));
            }
        }

        private void comboBoxSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawGames();
        }

        private void UpdateStandardComboBoxItems()
        {
            
            standartComboBoxItems.Clear();

            standartComboBoxItems.Add(new ComboBoxSelection() { DisplayName = "Все", Selector = "All" });

            if (Master.supabaseClient.Auth.CurrentUser != null)
            {
                standartComboBoxItems.Add(new ComboBoxSelection() { DisplayName = "Мои игры", Selector = Master.supabaseClient.Auth.CurrentUser.Id });
            }
        }

        private List<ComboBoxSelection> standartComboBoxItems = new List<ComboBoxSelection>();

        private class ComboBoxSelection
        {
           public string DisplayName { get; set; }

           public string Selector { get; set; }

           public override string ToString()
           {
               return DisplayName;
           }
        }
    }

}
