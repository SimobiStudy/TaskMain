namespace Task8
{
    partial class HistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelGames = new FlowLayoutPanel();
            comboBoxSelection = new ComboBox();
            SuspendLayout();
            // 
            // flowLayoutPanelGames
            // 
            flowLayoutPanelGames.AutoScroll = true;
            flowLayoutPanelGames.Location = new Point(41, 99);
            flowLayoutPanelGames.Name = "flowLayoutPanelGames";
            flowLayoutPanelGames.Size = new Size(419, 365);
            flowLayoutPanelGames.TabIndex = 0;
            // 
            // comboBoxSelection
            // 
            comboBoxSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelection.FormattingEnabled = true;
            comboBoxSelection.Location = new Point(41, 38);
            comboBoxSelection.Name = "comboBoxSelection";
            comboBoxSelection.Size = new Size(151, 28);
            comboBoxSelection.TabIndex = 1;
            comboBoxSelection.SelectedIndexChanged += comboBoxSelection_SelectedIndexChanged;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 486);
            Controls.Add(comboBoxSelection);
            Controls.Add(flowLayoutPanelGames);
            Name = "HistoryForm";
            Text = "История игр";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelGames;
        private ComboBox comboBoxSelection;
    }
}