using QuestionsXML;
using QuestionsXML.Types;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace FormsProj;

public partial class FormEdit : Form
{
    private readonly string _pathToAssets = "../../../Assets/Images/";

    private int currentTime = int.MaxValue;


    public FormEdit()
    {
        InitializeComponent();
        HideAll();
        openTestsDialog.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "../../../");
    }

    private ProgrammingQuiz _quizInfo;

    #region HideAndShows

    private void HideAll()
    {
        HideSelect();
        HideQuestions();
    }

    private void ShowAll()
    {
        ShowSelect();
        ShowQuestions();
    }

    private void HideSelect()
    {
        labelDiff.Hide();
        comboBoxDiff.Hide();
        buttonSave.Hide();
        labelTheme.Hide();
        comboBoxTheme.Hide();
        label1.Hide();
        comboBoxQuestions.Hide();
    }

    private void ShowSelect()
    {
        labelDiff.Show();
        comboBoxDiff.Show();
        buttonSave.Show();
        labelTheme.Show();
        comboBoxTheme.Show();
        label1.Show();
        comboBoxQuestions.Show();

    }

    private void HideQuestions()
    {
        labelValue.Hide();
        numericUDValue.Hide();
        flowLayoutPanel1.Hide();
        labelHeader.Hide();
        textBoxHeader.Hide();
        buttonAddImage.Hide();
    }

    private void ShowQuestions()
    {
        labelValue.Show();
        numericUDValue.Show();
        flowLayoutPanel1.Show();
        labelHeader.Show();
        textBoxHeader.Show();
        buttonAddImage.Show();
    }

    #endregion

    private void ChooseTestButton_Click(object sender, EventArgs e)
    {
        var dialogResult = openTestsDialog.ShowDialog();
        if (dialogResult != DialogResult.OK) return;

        _quizInfo = ProgrammingQuiz.GetTest(openTestsDialog.FileName);
        comboBoxDiff.Items.Clear();
        if (_quizInfo.Themes == null) return;
        foreach (var theme in _quizInfo.Themes) comboBoxTheme.Items.Add(theme);

        ShowSelect();
    }



    private void SelectQuestion(Question question)
    {
        ShowQuestions();
        if (question.ImagePath != null)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile(Path.Combine(_pathToAssets, question.ImagePath));
        }
        else
        {
            pictureBox1.Visible = false;
        }

        comboBoxAnswers.Items.Clear();
        foreach (var answer in question.Answers)
            comboBoxAnswers.Items.Add(answer);

        numericUDValue.Value = question.Reward;
        textBoxHeader.Text = question.Title;
    }

    private void returnToMainMenuButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBoxTheme.SelectedIndex == -1) return;
        if (comboBoxTheme.SelectedItem is not Theme) return;
        comboBoxDiff.Items.Clear();
        foreach (var diff in ((Theme)comboBoxTheme.SelectedItem).Difficulties)
            comboBoxDiff.Items.Add(diff);
    }

    private void comboBoxDiff_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBoxDiff.SelectedIndex == -1) return;
        if (comboBoxDiff.SelectedItem is not Difficulty) return;
        comboBoxQuestions.Items.Clear();


        foreach (var question in ((Difficulty)comboBoxDiff.SelectedItem).questions)
            comboBoxQuestions.Items.Add(question);
    }

    private void comboBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectQuestion((Question)comboBoxQuestions.SelectedItem);
    }

    private void buttonSelectDiff_Click(object sender, EventArgs e)
    {
        _quizInfo.Save();
    }

    private void textBoxHeader_TextChanged(object sender, EventArgs e)
    {
        var curQuestion = (Question)comboBoxQuestions.SelectedItem;
        if (curQuestion == null) return;

        curQuestion.Title = textBoxHeader.Text;
        UpdateComboBox(comboBoxQuestions, comboBoxQuestions.SelectedIndex);
    }

    private void buttonAddImage_Click(object sender, EventArgs e)
    {
        var curQuestion = (Question)comboBoxQuestions.SelectedItem;
        if (curQuestion == null) return;

        DialogResult dialogResult = imageAddFileDialog.ShowDialog();
        if (dialogResult != DialogResult.OK) return;
        var destPath = Path.Combine(_pathToAssets, Path.GetFileName(imageAddFileDialog.FileName));
        Image image;
        try
        {
            Image.FromFile(imageAddFileDialog.FileName);
            File.Copy(imageAddFileDialog.FileName, destPath, true);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка при загрузке файла изображения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        curQuestion.ImagePath = destPath;
        pictureBox1.Visible = true;
        pictureBox1.Image = Image.FromFile(destPath);
    }

    private void buttonAddAnswer_Click(object sender, EventArgs e)
    {
        var currentQuestion = (Question)comboBoxQuestions.SelectedItem;
        if (currentQuestion == null) return;

        var newAnswer = new Answer { Text = "Новый ответ", IsTrue = false };
        currentQuestion.Answers.Add(newAnswer);
        comboBoxAnswers.Items.Add(newAnswer);
        comboBoxAnswers.SelectedItem = newAnswer;

    }


    private void UpdateComboBox(ComboBox comboBox, int index)
    {
        if (index < 0 || index >= comboBoxAnswers.Items.Count) return;

        int selectionStart = comboBoxAnswers.SelectionStart;
        comboBoxAnswers.Items[index] = comboBoxAnswers.Items[index];
        comboBoxAnswers.SelectionStart = selectionStart;
    }


    private void checkBoxTrue_CheckedChanged(object sender, EventArgs e)
    {
        var currentAnswer = (Answer)comboBoxAnswers.SelectedItem;
        if (currentAnswer == null) return;

        currentAnswer.IsTrue = checkBoxTrue.Checked;
    }

    private void numericUDValue_ValueChanged(object sender, EventArgs e)
    {
        var curQuestion = (Question)comboBoxQuestions.SelectedItem;
        if (curQuestion == null) return;

        curQuestion.Reward = (int)numericUDValue.Value;
    }

    private void buttonRemoveAnswer_Click(object sender, EventArgs e)
    {
        var currentQuestion = (Question)comboBoxQuestions.SelectedItem;
        if (currentQuestion == null) return;
        var currentAnswer = (Answer)comboBoxAnswers.SelectedItem;
        if (currentAnswer == null) return;

        currentQuestion.Answers.Remove(currentAnswer);
        comboBoxAnswers.Items.Remove(currentAnswer); ;
        comboBoxAnswers.SelectedItem = comboBoxAnswers.Items.Count > 0 ? comboBoxAnswers.Items[0] : null;
    }

    private void comboBoxAnswers_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {

    }

    private void comboBoxAnswers_TextUpdate(object sender, EventArgs e)
    {
        var currentAnswer = (Answer)comboBoxAnswers.SelectedItem;
        if (currentAnswer == null) return;

        currentAnswer.Text = comboBoxAnswers.Text;
        UpdateComboBox(comboBoxAnswers, comboBoxAnswers.SelectedIndex);
    }

    private void comboBoxAnswers_TextChanged(object sender, EventArgs e)
    {
        var currentAnswer = (Answer)comboBoxAnswers.SelectedItem;
        if (currentAnswer == null) return;

        currentAnswer.Text = comboBoxAnswers.Text;
        UpdateComboBox(comboBoxAnswers, comboBoxAnswers.SelectedIndex);
    }
}