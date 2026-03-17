namespace Task4;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tabControl1 = new System.Windows.Forms.TabControl();
        tabPage1 = new System.Windows.Forms.TabPage();
        tabPage2 = new System.Windows.Forms.TabPage();
        tabPage3 = new System.Windows.Forms.TabPage();
        comboBoxTeam1 = new System.Windows.Forms.ComboBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        numericUDUp1 = new System.Windows.Forms.NumericUpDown();
        numericUDDown1 = new System.Windows.Forms.NumericUpDown();
        label3 = new System.Windows.Forms.Label();
        numericUDDown2 = new System.Windows.Forms.NumericUpDown();
        label4 = new System.Windows.Forms.Label();
        numericUDUp2 = new System.Windows.Forms.NumericUpDown();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        comboBoxTeam2 = new System.Windows.Forms.ComboBox();
        label7 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        dataGridMatch = new System.Windows.Forms.DataGridView();
        Команды = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
        GotGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
        WrongGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUDUp1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUDDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUDDown2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUDUp2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridMatch).BeginInit();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Controls.Add(tabPage3);
        tabControl1.Location = new System.Drawing.Point(1, -1);
        tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(880, 526);
        tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(button1);
        tabPage1.Controls.Add(label7);
        tabPage1.Controls.Add(numericUDDown2);
        tabPage1.Controls.Add(label4);
        tabPage1.Controls.Add(numericUDUp2);
        tabPage1.Controls.Add(label5);
        tabPage1.Controls.Add(label6);
        tabPage1.Controls.Add(comboBoxTeam2);
        tabPage1.Controls.Add(numericUDDown1);
        tabPage1.Controls.Add(label3);
        tabPage1.Controls.Add(numericUDUp1);
        tabPage1.Controls.Add(label2);
        tabPage1.Controls.Add(label1);
        tabPage1.Controls.Add(comboBoxTeam1);
        tabPage1.Location = new System.Drawing.Point(4, 31);
        tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage1.Size = new System.Drawing.Size(872, 491);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Ввод";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(button3);
        tabPage2.Controls.Add(button2);
        tabPage2.Controls.Add(dataGridMatch);
        tabPage2.Location = new System.Drawing.Point(4, 31);
        tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage2.Size = new System.Drawing.Size(872, 491);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Таблица";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // tabPage3
        // 
        tabPage3.Location = new System.Drawing.Point(4, 31);
        tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabPage3.Name = "tabPage3";
        tabPage3.Size = new System.Drawing.Size(872, 491);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "Диаграмма";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // comboBoxTeam1
        // 
        comboBoxTeam1.FormattingEnabled = true;
        comboBoxTeam1.Location = new System.Drawing.Point(35, 131);
        comboBoxTeam1.Name = "comboBoxTeam1";
        comboBoxTeam1.Size = new System.Drawing.Size(161, 30);
        comboBoxTeam1.TabIndex = 0;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(35, 100);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(87, 28);
        label1.TabIndex = 1;
        label1.Text = "Команда";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(35, 173);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(161, 29);
        label2.TabIndex = 2;
        label2.Text = "Забитых голов";
        // 
        // numericUDUp1
        // 
        numericUDUp1.Location = new System.Drawing.Point(35, 201);
        numericUDUp1.Name = "numericUDUp1";
        numericUDUp1.Size = new System.Drawing.Size(161, 29);
        numericUDUp1.TabIndex = 3;
        // 
        // numericUDDown1
        // 
        numericUDDown1.Location = new System.Drawing.Point(35, 295);
        numericUDDown1.Name = "numericUDDown1";
        numericUDDown1.Size = new System.Drawing.Size(161, 29);
        numericUDDown1.TabIndex = 5;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(35, 248);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(161, 44);
        label3.TabIndex = 4;
        label3.Text = "Пропущенных голов";
        // 
        // numericUDDown2
        // 
        numericUDDown2.Location = new System.Drawing.Point(475, 295);
        numericUDDown2.Name = "numericUDDown2";
        numericUDDown2.Size = new System.Drawing.Size(161, 29);
        numericUDDown2.TabIndex = 11;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(475, 248);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(161, 44);
        label4.TabIndex = 10;
        label4.Text = "Пропущенных голов";
        // 
        // numericUDUp2
        // 
        numericUDUp2.Location = new System.Drawing.Point(475, 201);
        numericUDUp2.Name = "numericUDUp2";
        numericUDUp2.Size = new System.Drawing.Size(161, 29);
        numericUDUp2.TabIndex = 9;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(475, 173);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(161, 29);
        label5.TabIndex = 8;
        label5.Text = "Забитых голов";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(549, 100);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(87, 28);
        label6.TabIndex = 7;
        label6.Text = "Команда";
        // 
        // comboBoxTeam2
        // 
        comboBoxTeam2.FormattingEnabled = true;
        comboBoxTeam2.Location = new System.Drawing.Point(475, 131);
        comboBoxTeam2.Name = "comboBoxTeam2";
        comboBoxTeam2.Size = new System.Drawing.Size(161, 30);
        comboBoxTeam2.TabIndex = 6;
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label7.Location = new System.Drawing.Point(35, 31);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(354, 31);
        label7.TabIndex = 12;
        label7.Text = "Введите результаты матча";
        // 
        // button1
        // 
        button1.Font = new System.Drawing.Font("Roboto SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        button1.Location = new System.Drawing.Point(35, 362);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(601, 74);
        button1.TabIndex = 13;
        button1.Text = "Ввести результаты";
        button1.UseVisualStyleBackColor = true;
        // 
        // dataGridMatch
        // 
        dataGridMatch.AllowUserToAddRows = false;
        dataGridMatch.AllowUserToDeleteRows = false;
        dataGridMatch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridMatch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        dataGridMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridMatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Команды, Score, GotGoals, WrongGoals });
        dataGridMatch.Location = new System.Drawing.Point(7, 38);
        dataGridMatch.Name = "dataGridMatch";
        dataGridMatch.ReadOnly = true;
        dataGridMatch.RowHeadersVisible = false;
        dataGridMatch.RowHeadersWidth = 51;
        dataGridMatch.Size = new System.Drawing.Size(631, 279);
        dataGridMatch.TabIndex = 0;
        dataGridMatch.Text = "dataGridView1";
        // 
        // Команды
        // 
        Команды.HeaderText = "Команды";
        Команды.MinimumWidth = 6;
        Команды.Name = "Команды";
        Команды.ReadOnly = true;
        Команды.Width = 119;
        // 
        // Score
        // 
        Score.HeaderText = "Очки";
        Score.MinimumWidth = 6;
        Score.Name = "Score";
        Score.ReadOnly = true;
        Score.Width = 81;
        // 
        // GotGoals
        // 
        GotGoals.HeaderText = "Количество забитых голов";
        GotGoals.MinimumWidth = 6;
        GotGoals.Name = "GotGoals";
        GotGoals.ReadOnly = true;
        GotGoals.Width = 199;
        // 
        // WrongGoals
        // 
        WrongGoals.HeaderText = "Количество пропущенных голов";
        WrongGoals.MinimumWidth = 6;
        WrongGoals.Name = "WrongGoals";
        WrongGoals.ReadOnly = true;
        WrongGoals.Width = 240;
        // 
        // button2
        // 
        button2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        button2.ForeColor = System.Drawing.Color.Crimson;
        button2.Location = new System.Drawing.Point(400, 390);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(165, 67);
        button2.TabIndex = 1;
        button2.Text = "Загрузить из файла";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        button3.ForeColor = System.Drawing.Color.DarkBlue;
        button3.Location = new System.Drawing.Point(74, 390);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(165, 67);
        button3.TabIndex = 2;
        button3.Text = "Сохранить в файл";
        button3.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(675, 516);
        Controls.Add(tabControl1);
        Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Text = "Футбольные результаты";
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericUDUp1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUDDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUDDown2).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUDUp2).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridMatch).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.DataGridViewTextBoxColumn Score;

    private System.Windows.Forms.DataGridViewTextBoxColumn Команды;
    private System.Windows.Forms.DataGridViewTextBoxColumn GotGoals;
    private System.Windows.Forms.DataGridViewTextBoxColumn WrongGoals;

    private System.Windows.Forms.DataGridView dataGridMatch;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.NumericUpDown numericUDDown2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown numericUDUp2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox comboBoxTeam2;
    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.NumericUpDown numericUDDown1;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUDUp1;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox comboBoxTeam1;

    private System.Windows.Forms.TabPage tabPage3;

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;

    #endregion
}