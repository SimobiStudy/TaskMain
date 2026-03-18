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
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        button1 = new Button();
        label7 = new Label();
        numericUDUp2 = new NumericUpDown();
        label5 = new Label();
        label6 = new Label();
        comboBoxTeam2 = new ComboBox();
        numericUDUp1 = new NumericUpDown();
        label2 = new Label();
        label1 = new Label();
        comboBoxTeam1 = new ComboBox();
        tabPage2 = new TabPage();
        button3 = new Button();
        button2 = new Button();
        dataGridMatch = new DataGridView();
        Команды = new DataGridViewTextBoxColumn();
        Score = new DataGridViewTextBoxColumn();
        GotGoals = new DataGridViewTextBoxColumn();
        WrongGoals = new DataGridViewTextBoxColumn();
        Winner = new DataGridViewTextBoxColumn();
        tabPage3 = new TabPage();
        chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
        openFileDialog1 = new OpenFileDialog();
        saveFileDialog1 = new SaveFileDialog();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUDUp2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUDUp1).BeginInit();
        tabPage2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridMatch).BeginInit();
        tabPage3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Controls.Add(tabPage3);
        tabControl1.Location = new Point(1, -1);
        tabControl1.Margin = new Padding(6, 3, 6, 3);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(1052, 629);
        tabControl1.TabIndex = 0;
        tabControl1.Click += tabControl1_Click;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(button1);
        tabPage1.Controls.Add(label7);
        tabPage1.Controls.Add(numericUDUp2);
        tabPage1.Controls.Add(label5);
        tabPage1.Controls.Add(label6);
        tabPage1.Controls.Add(comboBoxTeam2);
        tabPage1.Controls.Add(numericUDUp1);
        tabPage1.Controls.Add(label2);
        tabPage1.Controls.Add(label1);
        tabPage1.Controls.Add(comboBoxTeam1);
        tabPage1.Location = new Point(4, 31);
        tabPage1.Margin = new Padding(6, 3, 6, 3);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(6, 3, 6, 3);
        tabPage1.Size = new Size(1044, 594);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Ввод";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Font = new Font("Roboto SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
        button1.Location = new Point(55, 438);
        button1.Margin = new Padding(5, 3, 5, 3);
        button1.Name = "button1";
        button1.Size = new Size(939, 89);
        button1.TabIndex = 13;
        button1.Text = "Ввести результаты";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label7
        // 
        label7.Font = new Font("Roboto", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label7.Location = new Point(55, 37);
        label7.Margin = new Padding(5, 0, 5, 0);
        label7.Name = "label7";
        label7.Size = new Size(552, 37);
        label7.TabIndex = 12;
        label7.Text = "Введите результаты матча";
        // 
        // numericUDUp2
        // 
        numericUDUp2.Location = new Point(742, 243);
        numericUDUp2.Margin = new Padding(5, 3, 5, 3);
        numericUDUp2.Name = "numericUDUp2";
        numericUDUp2.Size = new Size(251, 29);
        numericUDUp2.TabIndex = 9;
        // 
        // label5
        // 
        label5.Location = new Point(742, 209);
        label5.Margin = new Padding(5, 0, 5, 0);
        label5.Name = "label5";
        label5.Size = new Size(251, 35);
        label5.TabIndex = 8;
        label5.Text = "Забитых голов";
        // 
        // label6
        // 
        label6.Location = new Point(858, 121);
        label6.Margin = new Padding(5, 0, 5, 0);
        label6.Name = "label6";
        label6.Size = new Size(136, 34);
        label6.TabIndex = 7;
        label6.Text = "Команда";
        label6.TextAlign = ContentAlignment.TopRight;
        // 
        // comboBoxTeam2
        // 
        comboBoxTeam2.FormattingEnabled = true;
        comboBoxTeam2.Location = new Point(742, 158);
        comboBoxTeam2.Margin = new Padding(5, 3, 5, 3);
        comboBoxTeam2.Name = "comboBoxTeam2";
        comboBoxTeam2.Size = new Size(249, 30);
        comboBoxTeam2.TabIndex = 6;
        // 
        // numericUDUp1
        // 
        numericUDUp1.Location = new Point(55, 243);
        numericUDUp1.Margin = new Padding(5, 3, 5, 3);
        numericUDUp1.Name = "numericUDUp1";
        numericUDUp1.Size = new Size(251, 29);
        numericUDUp1.TabIndex = 3;
        // 
        // label2
        // 
        label2.Location = new Point(55, 209);
        label2.Margin = new Padding(5, 0, 5, 0);
        label2.Name = "label2";
        label2.Size = new Size(251, 35);
        label2.TabIndex = 2;
        label2.Text = "Забитых голов";
        // 
        // label1
        // 
        label1.Location = new Point(55, 121);
        label1.Margin = new Padding(5, 0, 5, 0);
        label1.Name = "label1";
        label1.Size = new Size(136, 34);
        label1.TabIndex = 1;
        label1.Text = "Команда";
        // 
        // comboBoxTeam1
        // 
        comboBoxTeam1.FormattingEnabled = true;
        comboBoxTeam1.Location = new Point(55, 158);
        comboBoxTeam1.Margin = new Padding(5, 3, 5, 3);
        comboBoxTeam1.Name = "comboBoxTeam1";
        comboBoxTeam1.Size = new Size(249, 30);
        comboBoxTeam1.TabIndex = 0;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(button3);
        tabPage2.Controls.Add(button2);
        tabPage2.Controls.Add(dataGridMatch);
        tabPage2.Location = new Point(4, 29);
        tabPage2.Margin = new Padding(6, 3, 6, 3);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(6, 3, 6, 3);
        tabPage2.Size = new Size(1044, 596);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Таблица";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
        button3.ForeColor = Color.DarkBlue;
        button3.Location = new Point(115, 472);
        button3.Margin = new Padding(5, 3, 5, 3);
        button3.Name = "button3";
        button3.Size = new Size(258, 81);
        button3.TabIndex = 2;
        button3.Text = "Сохранить в файл";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button2
        // 
        button2.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
        button2.ForeColor = Color.Crimson;
        button2.Location = new Point(625, 472);
        button2.Margin = new Padding(5, 3, 5, 3);
        button2.Name = "button2";
        button2.Size = new Size(258, 81);
        button2.TabIndex = 1;
        button2.Text = "Загрузить из файла";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // dataGridMatch
        // 
        dataGridMatch.AllowUserToAddRows = false;
        dataGridMatch.AllowUserToDeleteRows = false;
        dataGridMatch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridMatch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dataGridMatch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridMatch.Columns.AddRange(new DataGridViewColumn[] { Команды, Score, GotGoals, WrongGoals, Winner });
        dataGridMatch.Location = new Point(11, 46);
        dataGridMatch.Margin = new Padding(5, 3, 5, 3);
        dataGridMatch.Name = "dataGridMatch";
        dataGridMatch.ReadOnly = true;
        dataGridMatch.RowHeadersVisible = false;
        dataGridMatch.RowHeadersWidth = 51;
        dataGridMatch.Size = new Size(986, 338);
        dataGridMatch.TabIndex = 0;
        dataGridMatch.Text = "dataGridView1";
        dataGridMatch.CellContentClick += dataGridMatch_CellContentClick;
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
        // Winner
        // 
        Winner.HeaderText = "Победитель";
        Winner.MinimumWidth = 6;
        Winner.Name = "Winner";
        Winner.ReadOnly = true;
        Winner.Width = 141;
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(chart1);
        tabPage3.Location = new Point(4, 29);
        tabPage3.Margin = new Padding(6, 3, 6, 3);
        tabPage3.Name = "tabPage3";
        tabPage3.Size = new Size(1044, 596);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "Диаграмма";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // chart1
        // 
        chartArea1.Name = "ChartArea1";
        chart1.ChartAreas.Add(chartArea1);
        legend1.Name = "Legend1";
        chart1.Legends.Add(legend1);
        chart1.Location = new Point(0, 3);
        chart1.Name = "chart1";
        series1.ChartArea = "ChartArea1";
        series1.Legend = "Legend1";
        series1.Name = "Series1";
        chart1.Series.Add(series1);
        chart1.Size = new Size(1038, 588);
        chart1.TabIndex = 0;
        chart1.Text = "chart1";
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        openFileDialog1.Filter = "Match файл|*t4ma";
        openFileDialog1.FileOk += openFileDialog1_FileOk;
        // 
        // saveFileDialog1
        // 
        saveFileDialog1.DefaultExt = "t4ma";
        saveFileDialog1.FileName = "matchL";
        saveFileDialog1.Filter = "Match файл|*t4ma";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 22F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1055, 625);
        Controls.Add(tabControl1);
        Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
        Margin = new Padding(4, 3, 4, 3);
        Name = "Form1";
        Text = "Футбольные результаты";
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericUDUp2).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUDUp1).EndInit();
        tabPage2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridMatch).EndInit();
        tabPage3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.DataGridView dataGridMatch;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.NumericUpDown numericUDUp2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox comboBoxTeam2;
    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUDUp1;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox comboBoxTeam1;

    private System.Windows.Forms.TabPage tabPage3;

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;

    #endregion
    private DataGridViewTextBoxColumn Команды;
    private DataGridViewTextBoxColumn Score;
    private DataGridViewTextBoxColumn GotGoals;
    private DataGridViewTextBoxColumn WrongGoals;
    private DataGridViewTextBoxColumn Winner;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private OpenFileDialog openFileDialog1;
    private SaveFileDialog saveFileDialog1;
}