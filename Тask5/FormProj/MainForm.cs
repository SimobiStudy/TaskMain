using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using DictClass;
using UtfUnknown;

namespace FormProj;

public partial class MainForm : Form
{
    private WordDictionary _wordDictionary;

    private bool CheckDictionary()
    {
        if (_wordDictionary == null)
        {
            ShowError("Словарь не загружен"); return false;
        }

        return true;
    }
    
    public MainForm()
    {
        InitializeComponent();
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    }

    private void listBoxWords_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBoxWords.SelectedIndices.Count == 0) return;
        string word = _wordDictionary.Words[listBoxWords.SelectedIndices[0]] as string;
        if (word == null) return;

        textBox1.Text = word;
    }



    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void ShowError(string text)
    {
        MessageBox.Show(text, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        if (!CheckDictionary()) return;
        _wordDictionary.AddWord(textBox1.Text);
        UpdateInfo();
    }

    private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        textBox1.Text = textBox1.Text.Trim().ToLower();
        if (textBox1.Text.Any(x => Char.IsWhiteSpace(x) || Char.IsDigit(x)))
        {
            ShowError("Это не слово");
            e.Cancel = true;
        }
    }

    private void buttonRemove_Click(object sender, EventArgs e)
    {
        if (!CheckDictionary()) return;
        _wordDictionary.RemoveWord(textBox1.Text);
        UpdateInfo();
    }

    private void UpdateInfo()
    {
        var wordCount = _wordDictionary?.Words.Count ?? 0;
        WordCountLabel.Text = "Слов в словаре: " + wordCount.ToString();

        if (_wordDictionary == null)
        {
            listBoxWords.VirtualListSize = 0;
            DictStatusLabel.Text = "Словарь не открыт";
        }
        else
        {
            listBoxWords.VirtualListSize = _wordDictionary.Words.Count;
            DictStatusLabel.Text = "Словарь открыт";
        }

        listBoxWords.Invalidate();
            
    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {
        if (!CheckDictionary()) return;
        var found = _wordDictionary.Words.FindIndex(x => x.StartsWith(textBox1.Text));
        if (found == -1)
        {
            ShowError("Слово не найдено");
            return;
        }
        SelectItem(found);
    }

    private void SelectItem(int index)
    {
        listBoxWords.SelectedIndices.Clear();
        listBoxWords.SelectedIndices.Add(index);

        listBoxWords.FocusedItem = listBoxWords.Items[index];
        listBoxWords.EnsureVisible(index);
    }

    private void openDictButton_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = openDictDialog.ShowDialog();
        if (dialogResult != DialogResult.OK) return;
        if (Path.GetExtension(openDictDialog.FileName) != ".txt")
        {
            ShowError("Словарь должен быть .txt файлом"); return;
        }

        try
        {
            // Учет кодировки
            _wordDictionary = new WordDictionary(openDictDialog.FileName, CharsetDetector.DetectFromFile(openDictDialog.FileName).Detected.Encoding);
            UpdateInfo();
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }

    private void saveDictButton_Click(object sender, EventArgs e)
    {
        if (!CheckDictionary()) return;
        DialogResult dialogResult = saveDictDialog.ShowDialog();
        if (dialogResult != DialogResult.OK) return;

        try
        {
            File.AppendAllLines(saveDictDialog.FileName, _wordDictionary.Words);
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }

    private void createNewDictButton_Click(object sender, EventArgs e)
    {
        this._wordDictionary = new WordDictionary();
        UpdateInfo();
    }

    private void deleteNewDictButton_Click(object sender, EventArgs e)
    {
        if (!CheckDictionary()) return;
        this._wordDictionary = null!;
        UpdateInfo();
    }

    private void startSearchFromButton_Click(object sender, EventArgs e)
    {
        if (!CheckDictionary()) return;
        if (string.IsNullOrWhiteSpace(startSearchFromTextbox.Text))
        {
            ShowError("Введите букву или символы для начала поиска (Справа от кнопки)");
            return;
        }
        
        var text = startSearchFromTextbox.Text;
        var found = _wordDictionary.Words.FindIndex(x => x.StartsWith(text));
        if (found == -1)
        {
            ShowError("Слов с такой буквы или последовательности не существует");
            return;
        }
        
        SelectItem(found);
    }

    private void getPalindromesButton_Click(object sender, EventArgs e)
    {
        if (!CheckDictionary()) return;
        DialogResult dialogResult = savePalindromesDialog.ShowDialog();
        if (dialogResult != DialogResult.OK) return;
        try
        {
            _wordDictionary.SearchPalindromesToFile(savePalindromesDialog.FileName);
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }
    
    private void toolStripFindLevenstein_Click(object sender, EventArgs e)
    {
        if (!CheckDictionary()) return;
        var word = textBox1.Text;
        if (string.IsNullOrWhiteSpace(word) || !_wordDictionary.HasWord(word))
        {
            ShowError("Введите верное слово в словаре");
            return;
        }

        DialogResult dialogResult = saveLevensteinFile.ShowDialog();
        if (dialogResult != DialogResult.OK) return;
        
        File.WriteAllLines(saveLevensteinFile.FileName,  _wordDictionary.SearchLevensteinDistance(word, 3));
    }

    private void listBoxWords_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
    {
        if (_wordDictionary == null)
        {
            e.Item = new ListViewItem();
            return;
        }
        if (e.ItemIndex >= 0 && e.ItemIndex < _wordDictionary.Words.Count)
        {
            var data = _wordDictionary.Words[e.ItemIndex];
            e.Item = new ListViewItem(data);
        }
    }
}