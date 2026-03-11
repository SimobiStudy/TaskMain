using System.Data;
using System.Text;

namespace MainForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        dataGridView1.ColumnCount = 3;
        dataGridView1.Columns[0].Name = "A";
        dataGridView1.Columns[1].Name = "B";
        dataGridView1.Columns[2].Name = "C";
    }

    private void GenerateTriangles()
    {
        dataGridView1.Rows.Clear();
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            int a; int b; int c;
            do
            {
                a = random.Next(1, 150);
                b = random.Next(1, 150);
                c = random.Next(1, 150);
            } while (!TriangleCalculations.ValidateTriangle(new Triangle(a,b,c)));
            
            dataGridView1.Rows.Add(a, b, c);
        }
    }



    private void GetAndWriteResults()
    {
        DialogResult dialogResult = saveFileDialog1.ShowDialog();
        if (dialogResult != DialogResult.OK)
            return;

        int count = 1;
        File.Delete(saveFileDialog1.FileName);
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            if (row.IsNewRow) continue;
            int a = Convert.ToInt32(row.Cells[0].Value);
            int b = Convert.ToInt32(row.Cells[1].Value);
            int c = Convert.ToInt32(row.Cells[2].Value);
            var tria = new Triangle(a, b, c);
            var area = TriangleCalculations.GetTriangleArea(tria);
            var angles = TriangleCalculations.GetTriangleAngles(tria);
            var heights = TriangleCalculations.GetTriangleHeights(tria);
            string resultString = $"Треугольник {count}:\n" +
                                  $"Стороны: {a}, {b}, {c}:\n" +
                                  $"Площадь: {area}\n" +
                                  $"Углы: 1 - {Math.Round(angles[0], 4)}, 2 - {Math.Round(angles[1], 4)}, 3 - {Math.Round(angles[2], 4)}\n" +
                                  $"Высоты: 1 - {Math.Round(heights[0], 4)}, 2 - {Math.Round(heights[1], 4)}, 3 - {Math.Round(heights[2], 4)}\n\n";

            File.AppendAllText(saveFileDialog1.FileName, resultString);
            count++;
        }

    }

    private void button2_Click(object sender, EventArgs e)
    {
        GetAndWriteResults();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        GenerateTriangles();
    }
}