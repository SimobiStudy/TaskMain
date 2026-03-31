namespace Task8
{
    partial class OptionsMenu
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
            comboBoxImage = new ComboBox();
            labelPicture = new Label();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxImage
            // 
            comboBoxImage.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxImage.FormattingEnabled = true;
            comboBoxImage.Location = new Point(36, 113);
            comboBoxImage.Name = "comboBoxImage";
            comboBoxImage.Size = new Size(259, 28);
            comboBoxImage.TabIndex = 0;
            comboBoxImage.Format += comboBoxImage_Format;
            // 
            // labelPicture
            // 
            labelPicture.AutoSize = true;
            labelPicture.Location = new Point(36, 75);
            labelPicture.Name = "labelPicture";
            labelPicture.Size = new Size(74, 20);
            labelPicture.TabIndex = 1;
            labelPicture.Text = "Картинка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 28);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "Фон";
            // 
            // label2
            // 
            label2.BackColor = Color.Gray;
            label2.Location = new Point(264, 28);
            label2.Name = "label2";
            label2.Size = new Size(31, 27);
            label2.TabIndex = 3;
            label2.Click += label2_Click;
            // 
            // OptionsMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 168);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelPicture);
            Controls.Add(comboBoxImage);
            Name = "OptionsMenu";
            Text = "Настройки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxImage;
        private Label labelPicture;
        private Label label1;
        private ColorDialog colorDialog1;
        private Label label2;
    }
}