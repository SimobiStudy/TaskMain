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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        saveDictDialog = new System.Windows.Forms.SaveFileDialog();
        openDictDialog = new System.Windows.Forms.OpenFileDialog();
        textBox1 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        buttonAdd = new System.Windows.Forms.Button();
        buttonRemove = new System.Windows.Forms.Button();
        buttonSearch = new System.Windows.Forms.Button();
        toolStrip1 = new System.Windows.Forms.ToolStrip();
        toolStripOpen = new System.Windows.Forms.ToolStripDropDownButton();
        openDictButton = new System.Windows.Forms.ToolStripMenuItem();
        saveDictButton = new System.Windows.Forms.ToolStripMenuItem();
        createNewDictButton = new System.Windows.Forms.ToolStripMenuItem();
        deleteNewDictButton = new System.Windows.Forms.ToolStripMenuItem();
        startSearchFromButton = new System.Windows.Forms.ToolStripMenuItem();
        startSearchFromTextbox = new System.Windows.Forms.ToolStripTextBox();
        toolStripWork = new System.Windows.Forms.ToolStripDropDownButton();
        FindLevensteinButton = new System.Windows.Forms.ToolStripMenuItem();
        getPalindromes = new System.Windows.Forms.ToolStripMenuItem();
        statusStrip1 = new System.Windows.Forms.StatusStrip();
        WordCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
        DictStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        savePalindromesDialog = new System.Windows.Forms.SaveFileDialog();
        saveLevensteinFile = new System.Windows.Forms.SaveFileDialog();
        listBoxWords = new System.Windows.Forms.ListView();
        columnHeader1 = new System.Windows.Forms.ColumnHeader();
        toolStrip1.SuspendLayout();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // saveDictDialog
        // 
        saveDictDialog.DefaultExt = "txt";
        saveDictDialog.FileName = "dict";
        saveDictDialog.Filter = "txt файлы|*.txt|Все файлы|*";
        saveDictDialog.Title = "Выберите файл для сохранения словаря";
        // 
        // openDictDialog
        // 
        openDictDialog.DefaultExt = "txt";
        openDictDialog.FileName = "dict";
        openDictDialog.Filter = "txt файлы|*.txt|Все файлы|*";
        openDictDialog.Title = "Открыть файл словаря";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(43, 73);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(185, 27);
        textBox1.TabIndex = 4;
        textBox1.Validating += textBox1_Validating;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Roboto SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(43, 47);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(128, 23);
        label1.TabIndex = 5;
        label1.Text = "Введите слово:";
        // 
        // buttonAdd
        // 
        buttonAdd.Font = new System.Drawing.Font("Roboto SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        buttonAdd.ForeColor = System.Drawing.Color.ForestGreen;
        buttonAdd.Location = new System.Drawing.Point(57, 128);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new System.Drawing.Size(151, 53);
        buttonAdd.TabIndex = 6;
        buttonAdd.Text = "Добавить";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // buttonRemove
        // 
        buttonRemove.Font = new System.Drawing.Font("Roboto SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        buttonRemove.ForeColor = System.Drawing.Color.DarkRed;
        buttonRemove.Location = new System.Drawing.Point(57, 212);
        buttonRemove.Name = "buttonRemove";
        buttonRemove.Size = new System.Drawing.Size(151, 53);
        buttonRemove.TabIndex = 7;
        buttonRemove.Text = "Удалить";
        buttonRemove.UseVisualStyleBackColor = true;
        buttonRemove.Click += buttonRemove_Click;
        // 
        // buttonSearch
        // 
        buttonSearch.Font = new System.Drawing.Font("Roboto SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        buttonSearch.ForeColor = System.Drawing.Color.RoyalBlue;
        buttonSearch.Location = new System.Drawing.Point(57, 289);
        buttonSearch.Name = "buttonSearch";
        buttonSearch.Size = new System.Drawing.Size(151, 53);
        buttonSearch.TabIndex = 8;
        buttonSearch.Text = "Найти";
        buttonSearch.UseVisualStyleBackColor = true;
        buttonSearch.Click += buttonSearch_Click;
        // 
        // toolStrip1
        // 
        toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripOpen, toolStripWork });
        toolStrip1.Location = new System.Drawing.Point(0, 0);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new System.Drawing.Size(617, 27);
        toolStrip1.TabIndex = 9;
        toolStrip1.Text = "toolStrip1";
        // 
        // toolStripOpen
        // 
        toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
        toolStripOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openDictButton, saveDictButton, createNewDictButton, deleteNewDictButton, startSearchFromButton });
        toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
        toolStripOpen.Name = "toolStripOpen";
        toolStripOpen.Size = new System.Drawing.Size(82, 24);
        toolStripOpen.Text = "Словарь";
        // 
        // openDictButton
        // 
        openDictButton.Name = "openDictButton";
        openDictButton.Size = new System.Drawing.Size(259, 26);
        openDictButton.Text = "Открыть словарь";
        openDictButton.Click += openDictButton_Click;
        // 
        // saveDictButton
        // 
        saveDictButton.Name = "saveDictButton";
        saveDictButton.Size = new System.Drawing.Size(259, 26);
        saveDictButton.Text = "Сохранить словарь";
        saveDictButton.Click += saveDictButton_Click;
        // 
        // createNewDictButton
        // 
        createNewDictButton.Name = "createNewDictButton";
        createNewDictButton.Size = new System.Drawing.Size(259, 26);
        createNewDictButton.Text = "Создать новый словарь";
        createNewDictButton.Click += createNewDictButton_Click;
        // 
        // deleteNewDictButton
        // 
        deleteNewDictButton.Name = "deleteNewDictButton";
        deleteNewDictButton.Size = new System.Drawing.Size(259, 26);
        deleteNewDictButton.Text = "Удалить новый словарь";
        deleteNewDictButton.Click += deleteNewDictButton_Click;
        // 
        // startSearchFromButton
        // 
        startSearchFromButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { startSearchFromTextbox });
        startSearchFromButton.Name = "startSearchFromButton";
        startSearchFromButton.Size = new System.Drawing.Size(259, 26);
        startSearchFromButton.Text = "Начать поиск с буквы";
        startSearchFromButton.Click += startSearchFromButton_Click;
        // 
        // startSearchFromTextbox
        // 
        startSearchFromTextbox.Name = "startSearchFromTextbox";
        startSearchFromTextbox.Size = new System.Drawing.Size(100, 27);
        startSearchFromTextbox.Text = "а";
        // 
        // toolStripWork
        // 
        toolStripWork.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
        toolStripWork.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { FindLevensteinButton, getPalindromes });
        toolStripWork.Image = ((System.Drawing.Image)resources.GetObject("toolStripWork.Image"));
        toolStripWork.ImageTransparentColor = System.Drawing.Color.Magenta;
        toolStripWork.Name = "toolStripWork";
        toolStripWork.Size = new System.Drawing.Size(163, 24);
        toolStripWork.Text = "Работа со словарем";
        // 
        // FindLevensteinButton
        // 
        FindLevensteinButton.Name = "FindLevensteinButton";
        FindLevensteinButton.Size = new System.Drawing.Size(253, 26);
        FindLevensteinButton.Text = "Поиск расстоянием";
        FindLevensteinButton.Click += toolStripFindLevenstein_Click;
        // 
        // getPalindromes
        // 
        getPalindromes.Name = "getPalindromes";
        getPalindromes.Size = new System.Drawing.Size(253, 26);
        getPalindromes.Text = "Получить палиндромы";
        getPalindromes.Click += getPalindromesButton_Click;
        // 
        // statusStrip1
        // 
        statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { WordCountLabel, DictStatusLabel });
        statusStrip1.Location = new System.Drawing.Point(0, 425);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new System.Drawing.Size(617, 26);
        statusStrip1.TabIndex = 10;
        statusStrip1.Text = "statusStrip1";
        // 
        // WordCountLabel
        // 
        WordCountLabel.Name = "WordCountLabel";
        WordCountLabel.Size = new System.Drawing.Size(131, 20);
        WordCountLabel.Text = "Слов в словаре: 0";
        // 
        // DictStatusLabel
        // 
        DictStatusLabel.Name = "DictStatusLabel";
        DictStatusLabel.Size = new System.Drawing.Size(141, 20);
        DictStatusLabel.Text = "Словарь не открыт";
        // 
        // savePalindromesDialog
        // 
        savePalindromesDialog.DefaultExt = "txt";
        savePalindromesDialog.FileName = "palindromes";
        savePalindromesDialog.Filter = "txt файлы|*.txt|Все файлы|*";
        savePalindromesDialog.Title = "Выберите файл для сохранения палиндромов";
        // 
        // saveLevensteinFile
        // 
        saveLevensteinFile.DefaultExt = "txt";
        saveLevensteinFile.FileName = "distancesWords";
        saveLevensteinFile.Filter = "txt файлы|*.txt|Все файлы|*";
        saveLevensteinFile.Title = "Выберите файл для сохранения слов с расстоянием не менее 3";
        // 
        // listBoxWords
        // 
        listBoxWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1 });
        listBoxWords.FullRowSelect = true;
        listBoxWords.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
        listBoxWords.Location = new System.Drawing.Point(412, 66);
        listBoxWords.MultiSelect = false;
        listBoxWords.Name = "listBoxWords";
        listBoxWords.Size = new System.Drawing.Size(193, 359);
        listBoxWords.TabIndex = 11;
        listBoxWords.UseCompatibleStateImageBehavior = false;
        listBoxWords.View = System.Windows.Forms.View.Details;
        listBoxWords.VirtualListSize = 50;
        listBoxWords.VirtualMode = true;
        listBoxWords.RetrieveVirtualItem += listBoxWords_RetrieveVirtualItem;
        listBoxWords.SelectedIndexChanged += listBoxWords_SelectedIndexChanged;
        // 
        // columnHeader1
        // 
        columnHeader1.Name = "columnHeader1";
        columnHeader1.Width = 189;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(617, 451);
        Controls.Add(listBoxWords);
        Controls.Add(statusStrip1);
        Controls.Add(toolStrip1);
        Controls.Add(buttonSearch);
        Controls.Add(buttonRemove);
        Controls.Add(buttonAdd);
        Controls.Add(label1);
        Controls.Add(textBox1);
        Text = "Работа со словарем";
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ColumnHeader columnHeader1;

    private System.Windows.Forms.SaveFileDialog saveLevensteinFile;

    private System.Windows.Forms.SaveFileDialog savePalindromesDialog;

    private System.Windows.Forms.ToolStripMenuItem getPalindromes;

    private System.Windows.Forms.ToolStripStatusLabel DictStatusLabel;

    private System.Windows.Forms.ToolStripStatusLabel WordCountLabel;

    private System.Windows.Forms.StatusStrip statusStrip1;

    private System.Windows.Forms.Button buttonRemove;

    private System.Windows.Forms.Button buttonAdd;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.ListView listBoxWords;

    private System.Windows.Forms.SaveFileDialog saveDictDialog;
    private System.Windows.Forms.OpenFileDialog openDictDialog;

    #endregion

    private Button buttonSearch;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripDropDownButton toolStripWork;
    private ToolStripMenuItem FindLevensteinButton;
    private ToolStripDropDownButton toolStripOpen;
    private ToolStripMenuItem openDictButton;
    private ToolStripMenuItem saveDictButton;
    private ToolStripMenuItem createNewDictButton;
    private ToolStripMenuItem deleteNewDictButton;
    private ToolStripMenuItem startSearchFromButton;
    private ToolStripTextBox startSearchFromTextbox;
}