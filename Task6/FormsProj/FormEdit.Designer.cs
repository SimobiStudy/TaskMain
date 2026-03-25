namespace FormsProj;

partial class FormEdit
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
        miniToolStrip = new ToolStrip();
        ChooseTestButton = new ToolStripButton();
        returnToMainMenuButton = new ToolStripButton();
        openTestsDialog = new OpenFileDialog();
        flowLayoutPanel1 = new FlowLayoutPanel();
        pictureBox1 = new PictureBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        panel2 = new Panel();
        checkBoxTrue = new CheckBox();
        comboBoxAnswers = new ComboBox();
        labelAnswers = new Label();
        panel1 = new Panel();
        buttonAddAnswer = new Button();
        buttonRemoveAnswer = new Button();
        labelHeader = new Label();
        comboBoxDiff = new ComboBox();
        labelDiff = new Label();
        labelTheme = new Label();
        comboBoxTheme = new ComboBox();
        timerTest = new System.Windows.Forms.Timer(components);
        comboBoxQuestions = new ComboBox();
        label1 = new Label();
        buttonSave = new Button();
        textBoxHeader = new TextBox();
        imageAddFileDialog = new OpenFileDialog();
        buttonAddImage = new Button();
        labelValue = new Label();
        numericUDValue = new NumericUpDown();
        miniToolStrip.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        tableLayoutPanel1.SuspendLayout();
        panel2.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUDValue).BeginInit();
        SuspendLayout();
        // 
        // miniToolStrip
        // 
        miniToolStrip.AccessibleName = "Выбор нового элемента";
        miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown;
        miniToolStrip.AutoSize = false;
        miniToolStrip.BackColor = Color.MistyRose;
        miniToolStrip.CanOverflow = false;
        miniToolStrip.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        miniToolStrip.GripStyle = ToolStripGripStyle.Hidden;
        miniToolStrip.ImageScalingSize = new Size(20, 20);
        miniToolStrip.Items.AddRange(new ToolStripItem[] { ChooseTestButton, returnToMainMenuButton });
        miniToolStrip.Location = new Point(0, 0);
        miniToolStrip.Name = "miniToolStrip";
        miniToolStrip.Size = new Size(1151, 46);
        miniToolStrip.TabIndex = 0;
        // 
        // ChooseTestButton
        // 
        ChooseTestButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        ChooseTestButton.Image = (Image)resources.GetObject("ChooseTestButton.Image");
        ChooseTestButton.ImageTransparentColor = Color.Magenta;
        ChooseTestButton.Name = "ChooseTestButton";
        ChooseTestButton.Size = new Size(169, 43);
        ChooseTestButton.Text = "Выбрать файл тестов";
        ChooseTestButton.Click += ChooseTestButton_Click;
        // 
        // returnToMainMenuButton
        // 
        returnToMainMenuButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        returnToMainMenuButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        returnToMainMenuButton.Image = (Image)resources.GetObject("returnToMainMenuButton.Image");
        returnToMainMenuButton.ImageTransparentColor = Color.Magenta;
        returnToMainMenuButton.Name = "returnToMainMenuButton";
        returnToMainMenuButton.Size = new Size(209, 43);
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
        flowLayoutPanel1.Location = new Point(367, 278);
        flowLayoutPanel1.Margin = new Padding(12, 3, 12, 3);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(654, 315);
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
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(panel2, 0, 1);
        tableLayoutPanel1.Controls.Add(labelAnswers, 0, 0);
        tableLayoutPanel1.Controls.Add(panel1, 0, 2);
        tableLayoutPanel1.Location = new Point(344, 3);
        tableLayoutPanel1.Margin = new Padding(10, 3, 10, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.787878F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.5606079F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.3092365F));
        tableLayoutPanel1.Size = new Size(268, 264);
        tableLayoutPanel1.TabIndex = 3;
        // 
        // panel2
        // 
        panel2.Controls.Add(checkBoxTrue);
        panel2.Controls.Add(comboBoxAnswers);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(3, 79);
        panel2.Name = "panel2";
        panel2.Size = new Size(262, 109);
        panel2.TabIndex = 16;
        // 
        // checkBoxTrue
        // 
        checkBoxTrue.AutoSize = true;
        checkBoxTrue.Location = new Point(3, 36);
        checkBoxTrue.Name = "checkBoxTrue";
        checkBoxTrue.Size = new Size(94, 24);
        checkBoxTrue.TabIndex = 15;
        checkBoxTrue.Text = "Верный";
        checkBoxTrue.UseVisualStyleBackColor = true;
        checkBoxTrue.CheckedChanged += checkBoxTrue_CheckedChanged;
        // 
        // comboBoxAnswers
        // 
        comboBoxAnswers.Dock = DockStyle.Fill;
        comboBoxAnswers.DropDownWidth = 600;
        comboBoxAnswers.FormattingEnabled = true;
        comboBoxAnswers.Location = new Point(0, 0);
        comboBoxAnswers.Margin = new Padding(5);
        comboBoxAnswers.Name = "comboBoxAnswers";
        comboBoxAnswers.Size = new Size(262, 28);
        comboBoxAnswers.TabIndex = 2;
        comboBoxAnswers.TextUpdate += comboBoxAnswers_TextUpdate;
        comboBoxAnswers.TextChanged += comboBoxAnswers_TextChanged;
        comboBoxAnswers.Validating += comboBoxAnswers_Validating;
        // 
        // labelAnswers
        // 
        labelAnswers.Location = new Point(0, 0);
        labelAnswers.Margin = new Padding(0);
        labelAnswers.Name = "labelAnswers";
        labelAnswers.Size = new Size(268, 31);
        labelAnswers.TabIndex = 3;
        labelAnswers.Text = "Варианты ответа";
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonAddAnswer);
        panel1.Controls.Add(buttonRemoveAnswer);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 191);
        panel1.Margin = new Padding(0);
        panel1.Name = "panel1";
        panel1.Size = new Size(268, 73);
        panel1.TabIndex = 4;
        // 
        // buttonAddAnswer
        // 
        buttonAddAnswer.Dock = DockStyle.Left;
        buttonAddAnswer.Location = new Point(0, 0);
        buttonAddAnswer.Name = "buttonAddAnswer";
        buttonAddAnswer.Size = new Size(114, 73);
        buttonAddAnswer.TabIndex = 15;
        buttonAddAnswer.Text = "Добавить";
        buttonAddAnswer.UseVisualStyleBackColor = true;
        buttonAddAnswer.Click += buttonAddAnswer_Click;
        // 
        // buttonRemoveAnswer
        // 
        buttonRemoveAnswer.Dock = DockStyle.Right;
        buttonRemoveAnswer.Location = new Point(154, 0);
        buttonRemoveAnswer.Name = "buttonRemoveAnswer";
        buttonRemoveAnswer.Size = new Size(114, 73);
        buttonRemoveAnswer.TabIndex = 16;
        buttonRemoveAnswer.Text = "Удалить";
        buttonRemoveAnswer.UseVisualStyleBackColor = true;
        buttonRemoveAnswer.Click += buttonRemoveAnswer_Click;
        // 
        // labelHeader
        // 
        labelHeader.AutoSize = true;
        labelHeader.Location = new Point(367, 185);
        labelHeader.Margin = new Padding(10, 0, 10, 0);
        labelHeader.Name = "labelHeader";
        labelHeader.Size = new Size(166, 20);
        labelHeader.TabIndex = 2;
        labelHeader.Text = "Заголовок вопроса";
        labelHeader.Visible = false;
        // 
        // comboBoxDiff
        // 
        comboBoxDiff.DropDownHeight = 250;
        comboBoxDiff.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxDiff.DropDownWidth = 600;
        comboBoxDiff.FormattingEnabled = true;
        comboBoxDiff.IntegralHeight = false;
        comboBoxDiff.Location = new Point(12, 177);
        comboBoxDiff.Name = "comboBoxDiff";
        comboBoxDiff.Size = new Size(236, 28);
        comboBoxDiff.TabIndex = 6;
        comboBoxDiff.SelectedIndexChanged += comboBoxDiff_SelectedIndexChanged;
        // 
        // labelDiff
        // 
        labelDiff.Location = new Point(12, 143);
        labelDiff.Margin = new Padding(10, 0, 10, 0);
        labelDiff.Name = "labelDiff";
        labelDiff.Size = new Size(186, 31);
        labelDiff.TabIndex = 4;
        labelDiff.Text = "Сложность";
        // 
        // labelTheme
        // 
        labelTheme.Location = new Point(12, 71);
        labelTheme.Margin = new Padding(10, 0, 10, 0);
        labelTheme.Name = "labelTheme";
        labelTheme.Size = new Size(186, 31);
        labelTheme.TabIndex = 9;
        labelTheme.Text = "Тема";
        // 
        // comboBoxTheme
        // 
        comboBoxTheme.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxTheme.DropDownWidth = 600;
        comboBoxTheme.FormattingEnabled = true;
        comboBoxTheme.Location = new Point(12, 105);
        comboBoxTheme.Name = "comboBoxTheme";
        comboBoxTheme.Size = new Size(236, 28);
        comboBoxTheme.TabIndex = 10;
        comboBoxTheme.SelectedIndexChanged += comboBoxTheme_SelectedIndexChanged;
        // 
        // timerTest
        // 
        timerTest.Interval = 1000;
        // 
        // comboBoxQuestions
        // 
        comboBoxQuestions.DropDownHeight = 250;
        comboBoxQuestions.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxQuestions.DropDownWidth = 600;
        comboBoxQuestions.FormattingEnabled = true;
        comboBoxQuestions.IntegralHeight = false;
        comboBoxQuestions.Location = new Point(12, 278);
        comboBoxQuestions.Name = "comboBoxQuestions";
        comboBoxQuestions.Size = new Size(236, 28);
        comboBoxQuestions.TabIndex = 11;
        comboBoxQuestions.SelectedIndexChanged += comboBoxQuestions_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.Location = new Point(12, 230);
        label1.Margin = new Padding(10, 0, 10, 0);
        label1.Name = "label1";
        label1.Size = new Size(186, 31);
        label1.TabIndex = 12;
        label1.Text = "Вопрос";
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(887, 71);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(151, 62);
        buttonSave.TabIndex = 8;
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += buttonSelectDiff_Click;
        // 
        // textBoxHeader
        // 
        textBoxHeader.Location = new Point(367, 233);
        textBoxHeader.Name = "textBoxHeader";
        textBoxHeader.Size = new Size(654, 28);
        textBoxHeader.TabIndex = 13;
        textBoxHeader.TextChanged += textBoxHeader_TextChanged;
        // 
        // imageAddFileDialog
        // 
        imageAddFileDialog.FileName = "image";
        imageAddFileDialog.Filter = "PNG файлы|*.png|JPG файлы|*.jpg|Все файлы|*.*";
        // 
        // buttonAddImage
        // 
        buttonAddImage.Location = new Point(207, 531);
        buttonAddImage.Name = "buttonAddImage";
        buttonAddImage.Size = new Size(145, 62);
        buttonAddImage.TabIndex = 14;
        buttonAddImage.Text = "Добавить картинку";
        buttonAddImage.UseVisualStyleBackColor = true;
        buttonAddImage.Click += buttonAddImage_Click;
        // 
        // labelValue
        // 
        labelValue.AutoSize = true;
        labelValue.Location = new Point(632, 185);
        labelValue.Margin = new Padding(10, 0, 10, 0);
        labelValue.Name = "labelValue";
        labelValue.Size = new Size(127, 20);
        labelValue.TabIndex = 16;
        labelValue.Text = "Кол-во баллов";
        labelValue.Visible = false;
        // 
        // numericUDValue
        // 
        numericUDValue.Location = new Point(871, 183);
        numericUDValue.Name = "numericUDValue";
        numericUDValue.Size = new Size(150, 28);
        numericUDValue.TabIndex = 17;
        numericUDValue.ValueChanged += numericUDValue_ValueChanged;
        // 
        // FormEdit
        // 
        AutoScaleDimensions = new SizeF(10F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1151, 634);
        Controls.Add(numericUDValue);
        Controls.Add(labelValue);
        Controls.Add(textBoxHeader);
        Controls.Add(label1);
        Controls.Add(buttonAddImage);
        Controls.Add(comboBoxQuestions);
        Controls.Add(labelTheme);
        Controls.Add(comboBoxTheme);
        Controls.Add(buttonSave);
        Controls.Add(labelDiff);
        Controls.Add(comboBoxDiff);
        Controls.Add(labelHeader);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(miniToolStrip);
        Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
        Location = new Point(19, 19);
        Margin = new Padding(4, 3, 4, 3);
        Name = "FormEdit";
        Text = "Изучение языков программирования (Администратор)";
        miniToolStrip.ResumeLayout(false);
        miniToolStrip.PerformLayout();
        flowLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        tableLayoutPanel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericUDValue).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

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
    private ToolStripButton returnToMainMenuButton;
    private Label labelTheme;
    private ComboBox comboBoxTheme;
    private System.Windows.Forms.Timer timerTest;
    private ComboBox comboBoxQuestions;
    private Label label1;
    private Button buttonSave;
    private TextBox textBoxHeader;
    private OpenFileDialog imageAddFileDialog;
    private Button buttonAddImage;
    private Panel panel1;
    private Button buttonAddAnswer;
    private Button buttonRemoveAnswer;
    private Panel panel2;
    private CheckBox checkBoxTrue;
    private Label labelValue;
    private NumericUpDown numericUDValue;
}