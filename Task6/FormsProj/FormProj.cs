using QuestionsXML;
using QuestionsXML.Types;
using System.Runtime.InteropServices.JavaScript;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormsProj;

public partial class FormProj : Form
{
    private readonly string _pathToAssets = "../../../Assets/Images/";

    private int currentTime = int.MaxValue;

    private List<Question> currentQuestions = new();
    private Question currentQuestion;
    private Dictionary<Question, Answer> answers = new();

    public FormProj()
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
        buttonSelectDiff.Hide();
        labelTheme.Hide();
        comboBoxTheme.Hide();
    }

    private void ShowSelect()
    {
        labelDiff.Show();
        comboBoxDiff.Show();
        buttonSelectDiff.Show();
        labelTheme.Show();
        comboBoxTheme.Show();
        
    }

    private void HideQuestions()
    {
        flowLayoutPanel1.Hide();
        labelHeader.Hide();
        panel1.Hide();
        buttonNext.Hide();
        buttonPrevious.Hide();
        labelTimer.Hide();
    }

    private void ShowQuestions()
    {
        flowLayoutPanel1.Show();
        labelHeader.Show();
        panel1.Show();
        buttonNext.Show();
        buttonPrevious.Show();
        labelTimer.Show();
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


    private void LoadDifficulty(Difficulty difficulty)
    {
        HideSelect();
        ShowQuestions();
        answers.Clear();
        if (difficulty.IsLocked) return;
        currentQuestions = difficulty.questions.Shuffle().Take(difficulty.questionsAmount).ToList();

        currentTime = difficulty.TimeToComplete;
        timerTest.Start();

        foreach (var question in currentQuestions) 
            question.Answers = question.Answers.Shuffle().ToList();
        SelectQuestion(currentQuestions.First());
    }

    private void SelectQuestion(Question question)
    {
        var findIndex = currentQuestions.FindIndex(x => x == question);
        if (findIndex == -1)
            throw new Exception("Вопрос не содержится в текущем списке вопросов");
        if (question.ImagePath != null)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile(Path.Combine(_pathToAssets, question.ImagePath));
        }
        else
        {
            pictureBox1.Visible = false;
        }

        buttonPrevious.Enabled = (findIndex > 0);

        buttonNext.Enabled = (findIndex < currentQuestions.Count - 1);

        comboBoxAnswers.Items.Clear();
        foreach (var answerToAdd in question.Answers)
            comboBoxAnswers.Items.Add(answerToAdd);

        if (answers.TryGetValue(question, out var answer))
            comboBoxAnswers.SelectedItem = answer;
        labelHeader.Text = question.ToString();
        currentQuestion = question;
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
        foreach (var diff in ((Theme)comboBoxTheme.SelectedItem).Difficulties.Where(x => !x.IsLocked))
            comboBoxDiff.Items.Add(diff);
    }

    private void buttonSelectDiff_Click(object sender, EventArgs e)
    {
        LoadDifficulty((Difficulty)comboBoxDiff.SelectedItem!);
    }

    private void UnlockNextDiff(Theme theme)
    {
        var mediumDiff = theme.Difficulties.Find(x => x.level == Difficulty.MediumDifficulty);
        if (mediumDiff.IsLocked)
            mediumDiff.IsLocked = false;
        else
            theme.Difficulties.Find(x => x.level == Difficulty.HardDifficulty).IsLocked = false;

        if (comboBoxTheme.SelectedIndex != -1)
        {
            comboBoxDiff.Items.Clear();
            foreach (var diff in ((Theme)comboBoxTheme.SelectedItem).Difficulties.Where(x => !x.IsLocked))
                comboBoxDiff.Items.Add(diff);
        }
    }



    private void comboBoxAnswers_SelectedIndexChanged(object sender, EventArgs e)
    {
        answers[currentQuestion] = (Answer)comboBoxAnswers.SelectedItem;
    }

    private void CloseTest()
    {
        timerTest.Stop();
        labelTimer.Hide();
        var result = GetResults();
        MessageBox.Show($"Ваши результаты за тест: {result}", "Результаты", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        if (result > 80)
        {
            UnlockNextDiff((Theme)comboBoxTheme.SelectedItem!);
            MessageBox.Show($"Вам разблокировалась новая сложность по теме: {comboBoxTheme.SelectedItem.ToString()}",
                "Разблокировка", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        HideQuestions();
        ShowSelect();
    }

    private int GetResults()
    {
        var result = 0;
        foreach (var questionAnswer in answers)
            if (questionAnswer.Value.IsTrue)
                result += questionAnswer.Key.Reward == 0 ? 10 : questionAnswer.Key.Reward;

        return Math.Min(result, 100);
    }

   



    private void timerTest_Tick(object sender, EventArgs e)
    {

        if (currentTime == int.MaxValue)
        {
            timerTest.Stop();
            labelTimer.Hide();
        }

        if (currentTime == 0)
        {
            CloseTest();
        }
        currentTime--;
        labelTimer.Text = TimeSpan.FromSeconds(currentTime).ToString(@"mm\:ss");
    }

    private void buttonCloseTest_Click(object sender, EventArgs e)
    {
        CloseTest();
    }

    private void buttonNext_Click(object sender, EventArgs e)
    {
        NextQuestion();
    }

    private void buttonPrevious_Click(object sender, EventArgs e)
    {
        PreviousQuestion();
    }
    private void PreviousQuestion()
    {
        SelectQuestion(currentQuestions[currentQuestions.FindIndex(x => x == currentQuestion) - 1]);
    }
    private void NextQuestion()
    {
        SelectQuestion(currentQuestions[currentQuestions.FindIndex(x => x == currentQuestion) + 1]);
    }
}