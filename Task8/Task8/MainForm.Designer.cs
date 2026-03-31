namespace Task8
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            сложностиToolStripMenuItem = new ToolStripMenuItem();
            легкаяToolStripMenuItem = new ToolStripMenuItem();
            средняяToolStripMenuItem = new ToolStripMenuItem();
            высокаяToolStripMenuItem = new ToolStripMenuItem();
            историяToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            ButtonLogin = new Button();
            buttonStartGame = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            labelSelectedDiff = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(140, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 398);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { сложностиToolStripMenuItem, историяToolStripMenuItem, настройкиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(683, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // сложностиToolStripMenuItem
            // 
            сложностиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { легкаяToolStripMenuItem, средняяToolStripMenuItem, высокаяToolStripMenuItem });
            сложностиToolStripMenuItem.Name = "сложностиToolStripMenuItem";
            сложностиToolStripMenuItem.Size = new Size(100, 24);
            сложностиToolStripMenuItem.Text = "Сложности";
            // 
            // легкаяToolStripMenuItem
            // 
            легкаяToolStripMenuItem.Name = "легкаяToolStripMenuItem";
            легкаяToolStripMenuItem.Size = new Size(151, 26);
            легкаяToolStripMenuItem.Text = "Легкая";
            легкаяToolStripMenuItem.Click += легкаяToolStripMenuItem_Click;
            // 
            // средняяToolStripMenuItem
            // 
            средняяToolStripMenuItem.Name = "средняяToolStripMenuItem";
            средняяToolStripMenuItem.Size = new Size(151, 26);
            средняяToolStripMenuItem.Text = "Средняя";
            средняяToolStripMenuItem.Click += средняяToolStripMenuItem_Click;
            // 
            // высокаяToolStripMenuItem
            // 
            высокаяToolStripMenuItem.Name = "высокаяToolStripMenuItem";
            высокаяToolStripMenuItem.Size = new Size(151, 26);
            высокаяToolStripMenuItem.Text = "Высокая";
            высокаяToolStripMenuItem.Click += высокаяToolStripMenuItem_Click;
            // 
            // историяToolStripMenuItem
            // 
            историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            историяToolStripMenuItem.Size = new Size(82, 24);
            историяToolStripMenuItem.Text = "История";
            историяToolStripMenuItem.Click += историяToolStripMenuItem_Click;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(98, 24);
            настройкиToolStripMenuItem.Text = "Настройки";
            настройкиToolStripMenuItem.Click += настройкиToolStripMenuItem_Click;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Location = new Point(558, 72);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(94, 29);
            ButtonLogin.TabIndex = 4;
            ButtonLogin.Text = "Войти";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += Войти_Click;
            // 
            // buttonStartGame
            // 
            buttonStartGame.Location = new Point(12, 171);
            buttonStartGame.Name = "buttonStartGame";
            buttonStartGame.Size = new Size(108, 59);
            buttonStartGame.TabIndex = 5;
            buttonStartGame.Text = "Начать игру";
            buttonStartGame.UseVisualStyleBackColor = true;
            buttonStartGame.Click += buttonStartGame_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // labelSelectedDiff
            // 
            labelSelectedDiff.Location = new Point(17, 57);
            labelSelectedDiff.Name = "labelSelectedDiff";
            labelSelectedDiff.Size = new Size(103, 81);
            labelSelectedDiff.TabIndex = 6;
            labelSelectedDiff.Text = "Выбранная сложность: Легкая";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(299, 41);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 7;
            label2.Text = "00:00";
            label2.Click += label2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 492);
            Controls.Add(label2);
            Controls.Add(labelSelectedDiff);
            Controls.Add(buttonStartGame);
            Controls.Add(ButtonLogin);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Игра собери картинку";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem сложностиToolStripMenuItem;
        private ToolStripMenuItem историяToolStripMenuItem;
        private Button ButtonLogin;
        private Button buttonStartGame;
        private ToolStripMenuItem легкаяToolStripMenuItem;
        private ToolStripMenuItem средняяToolStripMenuItem;
        private ToolStripMenuItem высокаяToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private Label labelSelectedDiff;
        private Label label2;
        private ToolStripMenuItem настройкиToolStripMenuItem;
    }
}
