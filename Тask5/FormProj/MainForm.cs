using System.Runtime.CompilerServices;
using DictClass;

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
    }

    private void listBoxWords_SelectedIndexChanged(object sender, EventArgs e)
    {
        string word = listBoxWords.SelectedItem as string;
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
    }

    private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        textBox1.Text = textBox1.Text.Trim();
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
        listBoxWords.SelectedIndex = found;
    }

    private void toolStripFindLevenstein_Click(object sender, EventArgs e)
    {

    }

    private void openDictButton_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = openDictDialog.ShowDialog();
        if (dialogResult != DialogResult.OK) return;

        if (Path.GetExtension(openDictDialog.FileName) != "txt")
        {
            ShowError("Словарь должен быть .txt файлом"); return;
        }

        try
        {
            _wordDictionary = new WordDictionary(openDictDialog.FileName);
            listBoxWords.DataSource = _wordDictionary.Words;
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
        listBoxWords.DataSource = _wordDictionary.Words;
    }

    private void deleteNewDictButton_Click(object sender, EventArgs e)
    {
        listBoxWords.DataSource = null;
        this._wordDictionary = null;
    }

    private void startSearchFromButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(startSearchFromTextbox.Text))
        {
            ShowError("Введите букву или символы для начала поиска (Справа от кнопки)");
            return;
        }
        
        var text = startSearchFromTextbox.Text;
        var found = _wordDictionary.Words.FindIndex(x => x.StartsWith(text));
        if (found == -1)
        {
            ShowError("Последовательность или слов с такой буквы не существует");
            return;
        }
    }
}