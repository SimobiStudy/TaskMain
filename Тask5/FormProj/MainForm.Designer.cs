using System.ComponentModel;

namespace FormProj;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
        saveDictDialog = new SaveFileDialog();
        openDictDialog = new OpenFileDialog();
        listBoxWords = new ListBox();
        textBox1 = new TextBox();
        label1 = new Label();
        buttonAdd = new Button();
        buttonRemove = new Button();
        button1 = new Button();
        toolStrip1 = new ToolStrip();
        toolStripOpen = new ToolStripDropDownButton();
        openDictButton = new ToolStripMenuItem();
        saveDictButton = new ToolStripMenuItem();
        createNewDictButton = new ToolStripMenuItem();
        deleteNewDictButton = new ToolStripMenuItem();
        startSearchFromButton = new ToolStripMenuItem();
        startSearchFromTextbox = new ToolStripTextBox();
        toolStripWork = new ToolStripDropDownButton();
        FindLevensteinButton = new ToolStripMenuItem();
        toolStripInfo = new ToolStripButton();
        toolStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // openDictDialog
        // 
        openDictDialog.DefaultExt = "txt";
        openDictDialog.FileName = "dict";
        openDictDialog.Filter = "txt Файлы|*.txt";
        openDictDialog.Title = "Открыть файл словаря";
        // 
        // listBoxWords
        // 
        listBoxWords.FormattingEnabled = true;
        listBoxWords.Location = new Point(443, 47);
        listBoxWords.Name = "listBoxWords";
        listBoxWords.Size = new Size(162, 384);
        listBoxWords.TabIndex = 3;
        listBoxWords.SelectedIndexChanged += listBoxWords_SelectedIndexChanged;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(43, 73);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(185, 27);
        textBox1.TabIndex = 4;
        textBox1.Validating += textBox1_Validating;
        // 
        // label1
        // 
        label1.Font = new Font("Roboto SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(43, 47);
        label1.Name = "label1";
        label1.Size = new Size(128, 23);
        label1.TabIndex = 5;
        label1.Text = "Введите слово:";
        // 
        // buttonAdd
        // 
        buttonAdd.Font = new Font("Roboto SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
        buttonAdd.ForeColor = Color.ForestGreen;
        buttonAdd.Location = new Point(57, 128);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(151, 53);
        buttonAdd.TabIndex = 6;
        buttonAdd.Text = "Добавить";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // buttonRemove
        // 
        buttonRemove.Font = new Font("Roboto SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
        buttonRemove.ForeColor = Color.DarkRed;
        buttonRemove.Location = new Point(57, 212);
        buttonRemove.Name = "buttonRemove";
        buttonRemove.Size = new Size(151, 53);
        buttonRemove.TabIndex = 7;
        buttonRemove.Text = "Удалить";
        buttonRemove.UseVisualStyleBackColor = true;
        buttonRemove.Click += buttonRemove_Click;
        // 
        // button1
        // 
        button1.Font = new Font("Roboto SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
        button1.ForeColor = Color.RoyalBlue;
        button1.Location = new Point(57, 289);
        button1.Name = "button1";
        button1.Size = new Size(151, 53);
        button1.TabIndex = 8;
        button1.Text = "Найти";
        button1.UseVisualStyleBackColor = true;
        button1.Click += buttonSearch_Click;
        // 
        // toolStrip1
        // 
        toolStrip1.ImageScalingSize = new Size(20, 20);
        toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripOpen, toolStripWork, toolStripInfo });
        toolStrip1.Location = new Point(0, 0);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(617, 27);
        toolStrip1.TabIndex = 9;
        toolStrip1.Text = "toolStrip1";
        // 
        // toolStripOpen
        // 
        toolStripOpen.DisplayStyle = ToolStripItemDisplayStyle.Text;
        toolStripOpen.DropDownItems.AddRange(new ToolStripItem[] { openDictButton, saveDictButton, createNewDictButton, deleteNewDictButton, startSearchFromButton });
        toolStripOpen.ImageTransparentColor = Color.Magenta;
        toolStripOpen.Name = "toolStripOpen";
        toolStripOpen.Size = new Size(82, 24);
        toolStripOpen.Text = "Словарь";
        // 
        // openDictButton
        // 
        openDictButton.Name = "openDictButton";
        openDictButton.Size = new Size(259, 26);
        openDictButton.Text = "Открыть словарь";
        openDictButton.Click += openDictButton_Click;
        // 
        // saveDictButton
        // 
        saveDictButton.Name = "saveDictButton";
        saveDictButton.Size = new Size(259, 26);
        saveDictButton.Text = "Сохранить словарь";
        saveDictButton.Click += saveDictButton_Click;
        // 
        // createNewDictButton
        // 
        createNewDictButton.Name = "createNewDictButton";
        createNewDictButton.Size = new Size(259, 26);
        createNewDictButton.Text = "Создать новый словарь";
        createNewDictButton.Click += createNewDictButton_Click;
        // 
        // deleteNewDictButton
        // 
        deleteNewDictButton.Name = "deleteNewDictButton";
        deleteNewDictButton.Size = new Size(259, 26);
        deleteNewDictButton.Text = "Удалить новый словарь";
        deleteNewDictButton.Click += deleteNewDictButton_Click;
        // 
        // startSearchFromButton
        // 
        startSearchFromButton.DropDownItems.AddRange(new ToolStripItem[] { startSearchFromTextbox });
        startSearchFromButton.Name = "startSearchFromButton";
        startSearchFromButton.Size = new Size(259, 26);
        startSearchFromButton.Text = "Начать поиск с буквы";
        startSearchFromButton.Click += startSearchFromButton_Click;
        // 
        // startSearchFromTextbox
        // 
        startSearchFromTextbox.Name = "startSearchFromTextbox";
        startSearchFromTextbox.Size = new Size(100, 27);
        startSearchFromTextbox.Text = "а";
        // 
        // toolStripWork
        // 
        toolStripWork.DisplayStyle = ToolStripItemDisplayStyle.Text;
        toolStripWork.DropDownItems.AddRange(new ToolStripItem[] { FindLevensteinButton });
        toolStripWork.Image = (Image)resources.GetObject("toolStripWork.Image");
        toolStripWork.ImageTransparentColor = Color.Magenta;
        toolStripWork.Name = "toolStripWork";
        toolStripWork.Size = new Size(163, 24);
        toolStripWork.Text = "Работа со словарем";
        // 
        // FindLevensteinButton
        // 
        FindLevensteinButton.Name = "FindLevensteinButton";
        FindLevensteinButton.Size = new Size(230, 26);
        FindLevensteinButton.Text = "Поиск расстоянием";
        FindLevensteinButton.Click += toolStripFindLevenstein_Click;
        // 
        // toolStripInfo
        // 
        toolStripInfo.DisplayStyle = ToolStripItemDisplayStyle.Text;
        toolStripInfo.Image = (Image)resources.GetObject("toolStripInfo.Image");
        toolStripInfo.ImageTransparentColor = Color.Magenta;
        toolStripInfo.Name = "toolStripInfo";
        toolStripInfo.Size = new Size(71, 24);
        toolStripInfo.Text = "Справка";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(617, 451);
        Controls.Add(toolStrip1);
        Controls.Add(button1);
        Controls.Add(buttonRemove);
        Controls.Add(buttonAdd);
        Controls.Add(label1);
        Controls.Add(textBox1);
        Controls.Add(listBoxWords);
        Name = "MainForm";
        Text = "MainForm";
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button buttonRemove;

    private System.Windows.Forms.Button buttonAdd;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.ListBox listBoxWords;

    private System.Windows.Forms.SaveFileDialog saveDictDialog;
    private System.Windows.Forms.OpenFileDialog openDictDialog;

    #endregion

    private Button button1;
    private ToolStrip toolStrip1;
    private ToolStripDropDownButton toolStripWork;
    private ToolStripButton toolStripInfo;
    private ToolStripMenuItem FindLevensteinButton;
    private ToolStripDropDownButton toolStripOpen;
    private ToolStripMenuItem openDictButton;
    private ToolStripMenuItem saveDictButton;
    private ToolStripMenuItem createNewDictButton;
    private ToolStripMenuItem deleteNewDictButton;
    private ToolStripMenuItem startSearchFromButton;
    private ToolStripTextBox startSearchFromTextbox;
}