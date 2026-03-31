using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Task8
{
    public partial class OptionsMenu : Form
    {
        private MainForm mainForm;

        private const string PathToAssets = "../../../Assets";
        public OptionsMenu(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            label2.BackColor = mainForm.SelectedBackColor;
            comboBoxImage.Items.Clear();
            comboBoxImage.Items.AddRange(Directory.GetFiles(PathToAssets));
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog1.ShowDialog();
            if (dialogResult != DialogResult.OK) return;

            label2.BackColor = colorDialog1.Color;

            mainForm.SelectedBackColor = colorDialog1.Color;
        }

        private void comboBoxImage_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is not string item)
            {
                return;
            }
            e.Value = Path.GetFileName(item);
        }
    }
}
