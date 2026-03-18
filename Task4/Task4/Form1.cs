using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task4;

public partial class Form1 : Form
{
    public List<Match> matches = new();

    public Form1()
    {
        InitializeComponent();
        saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var team1Name = comboBoxTeam1.Text;
        var team2Name = comboBoxTeam2.Text;
        if (string.IsNullOrWhiteSpace(team1Name) || string.IsNullOrWhiteSpace(team2Name))
        {
            MessageBox.Show("Пожалуйста, введите команду.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        matches.Add(new Match
        {
            Team1 = new Team
            { Name = team1Name, ShotGoals = (int)numericUDUp1.Value, GotGoals = (int)numericUDUp2.Value },
            Team2 = new Team
            { Name = team2Name, ShotGoals = (int)numericUDUp2.Value, GotGoals = (int)numericUDUp1.Value }
        });

        MessageBox.Show($"Команда {team1Name} - {team2Name}", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void dataGridMatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void FillDataGrid()
    {
        dataGridMatch.Rows.Clear();
        foreach (var match in matches)
        {
            var dataGridRow = new DataGridViewRow();
            dataGridRow.Cells.AddRange(
                new DataGridViewTextBoxCell { Value = $"{match.Team1.Name} - {match.Team2.Name}" },
                new DataGridViewTextBoxCell { Value = $"{match.Team1.GetScore()} - {match.Team2.GetScore()}" },
                new DataGridViewTextBoxCell { Value = $"{match.Team1.ShotGoals} - {match.Team2.ShotGoals}" },
                new DataGridViewTextBoxCell { Value = $"{match.Team1.GotGoals} - {match.Team2.GotGoals}" },
                new DataGridViewTextBoxCell { Value = $"{match.GetWinnerName()}" }
            );
            dataGridMatch.Rows.Add(dataGridRow);
        }
    }

    private void FillDiagram()
    {
        chart1.Series.Clear();
        // Форматировать диаграмму.
        chart1.BackColor = Color.Gray;
        chart1.BackSecondaryColor = Color.WhiteSmoke;
        chart1.BackGradientStyle = GradientStyle.DiagonalRight;

        chart1.BorderlineDashStyle = ChartDashStyle.Solid;
        chart1.BorderlineColor = Color.Gray;
        chart1.BorderSkin.SkinStyle = BorderSkinStyle.None;

        // Форматировать область диаграммы
        chart1.ChartAreas[0].BackColor = Color.White;
        // chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

        // Добавить и форматировать заголовок.
        chart1.Titles.Clear();
        chart1.Titles.Add("Результаты матчей в турнире");
        chart1.Titles[0].Font = new Font("Roboto", 20);

        var series = new Series("Очки команды");
        series.ChartType = SeriesChartType.Column;

        var teams = new Dictionary<string, int>();
        foreach (var match in matches)
        {
            if (!teams.ContainsKey(match.Team1.Name))
                teams.Add(match.Team1.Name, match.Team1.GetScore());
            else
                teams[match.Team1.Name] += match.Team1.GetScore();

            if (!teams.ContainsKey(match.Team2.Name))
                teams.Add(match.Team2.Name, match.Team2.GetScore());
            else
                teams[match.Team2.Name] += match.Team2.GetScore();
        }

        var counter = 0;
        foreach (var team in teams)
        {
            var index1 = series.Points.AddXY(counter, team.Value);
            series.Points[index1].AxisLabel = team.Key;
            counter++;
        }

        chart1.Series.Add(series);
    }

    private void tabControl1_Click(object sender, EventArgs e)
    {
        if (tabControl1.SelectedIndex == 1)
            FillDataGrid();
        if (tabControl1.SelectedIndex == 2)
            FillDiagram();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        var dialogResult = saveFileDialog1.ShowDialog();
        if (dialogResult != DialogResult.OK) return;

        StringBuilder stringBuilder = new StringBuilder();
        foreach (var match in matches)
        {
            stringBuilder.AppendLine(match.ToString());
        }
        File.WriteAllText(saveFileDialog1.FileName, stringBuilder.ToString());
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var dialogResult = openFileDialog1.ShowDialog();
        if (dialogResult != DialogResult.OK) return;

        matches.Clear();
        foreach (var line in File.ReadAllLines(openFileDialog1.FileName))
        {
            try
            {
                matches.Add(LoadFromString(line));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке строки: {line}\n{ex.Message}");
            }
        }
        FillDataGrid();
    }

    private readonly string regexPattern = @"^(.+)-(.+);(-?\d+)-(-?\d+);(-?\d+)-(-?\d+)";
    private Match LoadFromString(string strToLoad)
    {
        var match = Regex.Match(strToLoad.Trim(), regexPattern);
        if (!match.Success)
        {
            throw new Exception("Неверный формат строки");
        }


        Match matchToAdd = new Match
        {
            Team1 = new Team
            {
                Name = match.Groups[1].Value,
                ShotGoals = int.Parse(match.Groups[3].Value),
                GotGoals = int.Parse(match.Groups[5].Value)
            },
            Team2 = new Team
            {
                Name = match.Groups[2].Value,
                ShotGoals = int.Parse(match.Groups[4].Value),
                GotGoals = int.Parse(match.Groups[6].Value)
            }
        };
        return matchToAdd;
    }

    private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {

    }

    
}

public class Match
{
    public Team Team1 { get; set; }
    public Team Team2 { get; set; }

    public Team GetWinner()
    {
        var score1 = Team1.GetScore();
        var score2 = Team2.GetScore();
        if (score1 > score2)
            return Team1;
        if (score2 > score1)
            return Team2;
        return null;
    }
    public string GetWinnerName()
    {
        var winner = GetWinner();
        if (winner == null)
            return "Ничья";
        return winner.Name;
    }

    public override string ToString()
    {
        return $"{Team1.Name}-{Team2.Name};{Team1.ShotGoals}-{Team2.ShotGoals};{Team1.GotGoals}-{Team2.GotGoals}";
    }
}

public class Team
{
    public string Name { get; set; }
    public int ShotGoals { get; set; }
    public int GotGoals { get; set; }

    public int GetScore()
    {
        return ShotGoals - GotGoals;
    }
}