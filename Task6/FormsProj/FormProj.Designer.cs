namespace FormsProj;

partial class FormProj
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProj));
        miniToolStrip = new ToolStrip();
        ChooseTestButton = new ToolStripButton();
        returnToMainMenuButton = new ToolStripButton();
        openTestsDialog = new OpenFileDialog();
        flowLayoutPanel1 = new FlowLayoutPanel();
        pictureBox1 = new PictureBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        comboBoxAnswers = new ComboBox();
        labelAnswers = new Label();
        labelHeader = new Label();
        buttonNext = new Button();
        buttonPrevious = new Button();
        panel1 = new Panel();
        buttonCloseTest = new Button();
        comboBoxDiff = new ComboBox();
        labelDiff = new Label();
        labelTimer = new Label();
        buttonSelectDiff = new Button();
        labelTheme = new Label();
        comboBoxTheme = new ComboBox();
        timerTest = new System.Windows.Forms.Timer(components);
        miniToolStrip.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // miniToolStrip
        // 
        miniToolStrip.AccessibleName = "Выбор нового элемента";
        miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown;
        miniToolStrip.AutoSize = false;
        miniToolStrip.BackColor = Color.LightCyan;
        miniToolStrip.CanOverflow = false;
        miniToolStrip.Dock = DockStyle.None;
        miniToolStrip.GripStyle = ToolStripGripStyle.Hidden;
        miniToolStrip.ImageScalingSize = new Size(20, 20);
        miniToolStrip.Items.AddRange(new ToolStripItem[] { ChooseTestButton, returnToMainMenuButton });
        miniToolStrip.Location = new Point(0, 0);
        miniToolStrip.Name = "miniToolStrip";
        miniToolStrip.Size = new Size(901, 41);
        miniToolStrip.TabIndex = 0;
        // 
        // ChooseTestButton
        // 
        ChooseTestButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        ChooseTestButton.Image = (Image)resources.GetObject("ChooseTestButton.Image");
        ChooseTestButton.ImageTransparentColor = Color.Magenta;
        ChooseTestButton.Name = "ChooseTestButton";
        ChooseTestButton.Size = new Size(160, 38);
        ChooseTestButton.Text = "Выбрать файл тестов";
        ChooseTestButton.Click += ChooseTestButton_Click;
        // 
        // returnToMainMenuButton
        // 
        returnToMainMenuButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        returnToMainMenuButton.Font = new Font("Segoe UI", 9F);
        returnToMainMenuButton.Image = (Image)resources.GetObject("returnToMainMenuButton.Image");
        returnToMainMenuButton.ImageTransparentColor = Color.Magenta;
        returnToMainMenuButton.Name = "returnToMainMenuButton";
        returnToMainMenuButton.Size = new Size(200, 38);
        returnToMainMenuButton.Text = "Вернуться в главное меню";
        returnToMainMenuButton.ToolTipText = "Retu";
        returnToMainMenuButton.Click += returnToMainMenuButton_Click;
        // 
        // openTestsDialog
        // 
        openTestsDialog.DefaultExt = "xml";
        openTestsDialog.FileName = "test";
        openTestsDialog.Filter = "XML файлы|*.xml|Все файлы|*.*";
        openTestsDialog.Title = "Выберите файл с тестами";
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Controls.Add(pictureBox1);
        flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
        flowLayoutPanel1.Location = new Point(102, 156);
        flowLayoutPanel1.Margin = new Padding(12, 3, 12, 3);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(671, 306);
        flowLayoutPanel1.TabIndex = 1;
        flowLayoutPanel1.Visible = false;
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new Point(10, 3);
        pictureBox1.Margin = new Padding(10, 3, 10, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(314, 288);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(comboBoxAnswers, 0, 1);
        tableLayoutPanel1.Controls.Add(labelAnswers, 0, 0);
        tableLayoutPanel1.Location = new Point(344, 3);
        tableLayoutPanel1.Margin = new Padding(10, 3, 10, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(281, 115);
        tableLayoutPanel1.TabIndex = 3;
        // 
        // comboBoxAnswers
        // 
        comboBoxAnswers.Dock = DockStyle.Fill;
        comboBoxAnswers.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxAnswers.DropDownWidth = 600;
        comboBoxAnswers.FormattingEnabled = true;
        comboBoxAnswers.Location = new Point(0, 57);
        comboBoxAnswers.Margin = new Padding(0);
        comboBoxAnswers.Name = "comboBoxAnswers";
        comboBoxAnswers.Size = new Size(281, 28);
        comboBoxAnswers.TabIndex = 2;
        comboBoxAnswers.SelectedIndexChanged += comboBoxAnswers_SelectedIndexChanged;
        // 
        // labelAnswers
        // 
        labelAnswers.Location = new Point(0, 0);
        labelAnswers.Margin = new Padding(0);
        labelAnswers.Name = "labelAnswers";
        labelAnswers.Size = new Size(278, 31);
        labelAnswers.TabIndex = 3;
        labelAnswers.Text = "Варианты ответа";
        // 
        // labelHeader
        // 
        labelHeader.AutoSize = true;
        labelHeader.Location = new Point(102, 128);
        labelHeader.Margin = new Padding(10, 0, 10, 0);
        labelHeader.Name = "labelHeader";
        labelHeader.Size = new Size(132, 20);
        labelHeader.TabIndex = 2;
        labelHeader.Text = "QuestionHeader";
        labelHeader.Visible = false;
        // 
        // buttonNext
        // 
        buttonNext.Dock = DockStyle.Right;
        buttonNext.Location = new Point(491, 0);
        buttonNext.Margin = new Padding(10, 3, 10, 3);
        buttonNext.Name = "buttonNext";
        buttonNext.Size = new Size(180, 71);
        buttonNext.TabIndex = 3;
        buttonNext.Text = "Следующий вопрос";
        buttonNext.UseVisualStyleBackColor = true;
        buttonNext.Visible = false;
        buttonNext.Click += buttonNext_Click;
        // 
        // buttonPrevious
        // 
        buttonPrevious.Dock = DockStyle.Left;
        buttonPrevious.Location = new Point(0, 0);
        buttonPrevious.Margin = new Padding(10, 3, 10, 3);
        buttonPrevious.Name = "buttonPrevious";
        buttonPrevious.Size = new Size(180, 71);
        buttonPrevious.TabIndex = 4;
        buttonPrevious.Text = "Предыдущий вопрос";
        buttonPrevious.UseVisualStyleBackColor = true;
        buttonPrevious.Visible = false;
        buttonPrevious.Click += buttonPrevious_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonCloseTest);
        panel1.Controls.Add(buttonNext);
        panel1.Controls.Add(buttonPrevious);
        panel1.Location = new Point(102, 497);
        panel1.Margin = new Padding(10, 3, 10, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(671, 71);
        panel1.TabIndex = 5;
        panel1.Visible = false;
        // 
        // buttonCloseTest
        // 
        buttonCloseTest.Anchor = AnchorStyles.Top;
        buttonCloseTest.Location = new Point(252, 0);
        buttonCloseTest.Name = "buttonCloseTest";
        buttonCloseTest.Size = new Size(179, 71);
        buttonCloseTest.TabIndex = 5;
        buttonCloseTest.Text = "Завершить тест";
        buttonCloseTest.UseVisualStyleBackColor = true;
        buttonCloseTest.Click += buttonCloseTest_Click;
        // 
        // comboBoxDiff
        // 
        comboBoxDiff.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxDiff.DropDownWidth = 600;
        comboBoxDiff.FormattingEnabled = true;
        comboBoxDiff.Location = new Point(425, 104);
        comboBoxDiff.Name = "comboBoxDiff";
        comboBoxDiff.Size = new Size(151, 28);
        comboBoxDiff.TabIndex = 6;
        // 
        // labelDiff
        // 
        labelDiff.Location = new Point(425, 70);
        labelDiff.Margin = new Padding(10, 0, 10, 0);
        labelDiff.Name = "labelDiff";
        labelDiff.Size = new Size(186, 31);
        labelDiff.TabIndex = 4;
        labelDiff.Text = "Выбрать сложность";
        // 
        // labelTimer
        // 
        labelTimer.AutoSize = true;
        labelTimer.Font = new Font("Roboto Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        labelTimer.Location = new Point(790, 70);
        labelTimer.Name = "labelTimer";
        labelTimer.Size = new Size(72, 28);
        labelTimer.TabIndex = 7;
        labelTimer.Text = "Timer";
        // 
        // buttonSelectDiff
        // 
        buttonSelectDiff.Location = new Point(610, 104);
        buttonSelectDiff.Name = "buttonSelectDiff";
        buttonSelectDiff.Size = new Size(94, 29);
        buttonSelectDiff.TabIndex = 8;
        buttonSelectDiff.Text = "Выбрать";
        buttonSelectDiff.UseVisualStyleBackColor = true;
        buttonSelectDiff.Click += buttonSelectDiff_Click;
        // 
        // labelTheme
        // 
        labelTheme.Location = new Point(102, 71);
        labelTheme.Margin = new Padding(10, 0, 10, 0);
        labelTheme.Name = "labelTheme";
        labelTheme.Size = new Size(186, 31);
        labelTheme.TabIndex = 9;
        labelTheme.Text = "Выбрать тему";
        // 
        // comboBoxTheme
        // 
        comboBoxTheme.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxTheme.DropDownWidth = 600;
        comboBoxTheme.FormattingEnabled = true;
        comboBoxTheme.Location = new Point(102, 105);
        comboBoxTheme.Name = "comboBoxTheme";
        comboBoxTheme.Size = new Size(310, 28);
        comboBoxTheme.TabIndex = 10;
        comboBoxTheme.SelectedIndexChanged += comboBoxTheme_SelectedIndexChanged;
        // 
        // timerTest
        // 
        timerTest.Interval = 1000;
        timerTest.Tick += timerTest_Tick;
        // 
        // FormProj
        // 
        AutoScaleDimensions = new SizeF(10F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(903, 590);
        Controls.Add(labelTheme);
        Controls.Add(comboBoxTheme);
        Controls.Add(buttonSelectDiff);
        Controls.Add(labelTimer);
        Controls.Add(labelDiff);
        Controls.Add(comboBoxDiff);
        Controls.Add(panel1);
        Controls.Add(labelHeader);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(miniToolStrip);
        Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
        Location = new Point(19, 19);
        Margin = new Padding(4, 3, 4, 3);
        Name = "FormProj";
        Text = "Изучение языков программирования (Пользователь)";
        miniToolStrip.ResumeLayout(false);
        miniToolStrip.PerformLayout();
        flowLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        tableLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Button buttonPrevious;

    private System.Windows.Forms.Button buttonNext;

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label labelHeader;
    private System.Windows.Forms.Label labelAnswers;
    private System.Windows.Forms.ComboBox comboBoxAnswers;
    private System.Windows.Forms.ComboBox comboBoxDiff;

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.OpenFileDialog openTestsDialog;

    private System.Windows.Forms.ToolStripButton ChooseTestButton;

    private System.Windows.Forms.ToolStrip miniToolStrip;

    #endregion

    
    private Label labelDiff;
    private Label labelTimer;
    private Button buttonSelectDiff;
    private ToolStripButton returnToMainMenuButton;
    private Label labelTheme;
    private ComboBox comboBoxTheme;
    private System.Windows.Forms.Timer timerTest;
    private Button buttonCloseTest;
}