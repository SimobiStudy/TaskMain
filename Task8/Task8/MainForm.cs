using System.Drawing.Text;
using System.Security.Cryptography;
using SupabaseReg;
using Task8;
using System.ComponentModel;



namespace Task8
{
    public partial class MainForm : Form
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color SelectedBackColor
        {
            get => this.BackColor;
            set => this.BackColor = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image SelectedImage
        {
            get => selectedImage;
            set => selectedImage = value;
        }

        private const string PathToAssets = "../../../Assets";
        public MainForm()
        {
            InitializeComponent();
        }

        private Difficulty selectedDifficulty = Difficulty.Difficulties[0];

        private TimeSpan _leftTime = TimeSpan.Zero;

        private Image selectedImage;
        public void StartGame()
        {



            _leftTime = selectedDifficulty.TimeLimit;
            Image img;
            if (selectedImage == null)
            {
                string file;
                var files = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), PathToAssets));
                if (files.Length > 1)
                    file = files[RandomNumberGenerator.GetInt32(0, files.Length - 1)];
                else
                    file = files[0];
                img = Image.FromFile(file);
            }
            else img = selectedImage;

            SplitImage(img);
            timer1.Start();
            InitializeBoard();
            CreateUI();
        }

        private Image[] imageFragments = new Image[16];
        private int fragmentSize;

        private void SplitImage(Image originalImage)
        {
            // Предполагаем, что картинка квадратная. Делим на 4.
            fragmentSize = panel1.Width / 4;

            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    int index = y * 4 + x;
                    if (index == 15) continue; // Последняя ячейка - пустая

                    Bitmap fragment = new Bitmap(fragmentSize, fragmentSize);
                    using (Graphics g = Graphics.FromImage(fragment))
                    {
                        // Вырезаем нужный кусок из оригинала
                        g.DrawImage(originalImage,
                            new Rectangle(0, 0, fragmentSize, fragmentSize),
                            new Rectangle(x * fragmentSize, y * fragmentSize, fragmentSize, fragmentSize),
                            GraphicsUnit.Pixel);
                    }
                    imageFragments[index] = fragment;
                }
            }
        }


        #region board manip

        private int[,] board;
        private Point emptyCell;

        private void InitializeBoard()
        {
            board = new int[4, 4];
            // Заполнение по умолчанию (собранный вид)
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    board[i, j] = i * 4 + j;

            emptyCell = new Point(3, 3);
            ShuffleBoard();
        }

        private void ShuffleBoard()
        {
            Random rand = new Random();
            int moves = 100; // Количество случайных сдвигов

            // Массив возможных направлений (dx, dy)
            Point[] directions = { new Point(0, -1), new Point(0, 1), new Point(-1, 0), new Point(1, 0) };

            for (int i = 0; i < moves; i++)
            {
                var validMoves = directions
                    .Select(d => new Point(emptyCell.X + d.X, emptyCell.Y + d.Y))
                    .Where(p => p.X >= 0 && p.X < 4 && p.Y >= 0 && p.Y < 4)
                    .ToList();

                Point move = validMoves[rand.Next(validMoves.Count)];

                // Меняем местами логически
                board[emptyCell.Y, emptyCell.X] = board[move.Y, move.X];
                board[move.Y, move.X] = 15;
                emptyCell = move;
            }
        }
        #endregion

        #region  UI




        private PictureBox[,] boxes;

        private void CreateUI()
        {
            boxes = new PictureBox[4, 4];
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    PictureBox pb = new PictureBox
                    {
                        Width = fragmentSize,
                        Height = fragmentSize,
                        Location = new Point(x * fragmentSize, y * fragmentSize),
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Tag = new Point(x, y) // Запоминаем координаты в сетке
                    };

                    pb.Click += PictureBox_Click;
                    boxes[y, x] = pb;
                    panel1.Controls.Add(pb);
                }
            }
            UpdateUI();

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedBox = sender as PictureBox;
            Point clickedPos = (Point)clickedBox.Tag;

            // Проверка соседства с пустой ячейкой (разница по X или Y равна 1)
            if (Math.Abs(clickedPos.X - emptyCell.X) + Math.Abs(clickedPos.Y - emptyCell.Y) == 1)
            {
                // Свап в логическом массиве
                board[emptyCell.Y, emptyCell.X] = board[clickedPos.Y, clickedPos.X];
                board[clickedPos.Y, clickedPos.X] = 15;

                // Обновляем координаты пустой ячейки
                emptyCell = clickedPos;

                UpdateUI();
                CheckWin();
            }
        }

        private void UpdateUI()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    int imageIndex = board[y, x];
                    if (imageIndex == 15)
                        boxes[y, x].Image = null; // Пустая ячейка
                    else
                        boxes[y, x].Image = imageFragments[imageIndex];
                }
            }
        }

        #endregion

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historyForm = new HistoryForm();
            historyForm.Show();
        }

        private void Войти_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _leftTime = _leftTime.Subtract(TimeSpan.FromSeconds(1));
            label2.Visible = true;
            label2.Text = $"{_leftTime:mm\\:ss}";

            if (_leftTime.TotalSeconds == 0)
                OnGameEnd(false);
        }

        private void SelectNewDifficulty(Difficulty difficulty)
        {
            selectedDifficulty = difficulty;
            labelSelectedDiff.Text = $"Выбранная сложность: {difficulty.Name}";
        }
        private void легкаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectNewDifficulty(Difficulty.Difficulties[0]);
        }

        private void средняяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectNewDifficulty(Difficulty.Difficulties[1]);
        }

        private void высокаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectNewDifficulty(Difficulty.Difficulties[2]);
        }

        private void CheckWin()
        {
            // Проверяем, что все фрагменты на своих местах
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (board[i, j] != i * 4 + j)
                        return; // Если нашли фрагмент не на месте - выходим
                                // Если дошли сюда - игрок собрал картинку

            OnGameEnd(true);
        }

        private async void OnGameEnd(bool isWin)
        {
            string message;
            if (isWin)
            {
                message = $"Поздравляем! Вы выиграли за {selectedDifficulty.TimeLimit - _leftTime}!";

            }
            else message = "Время вышло, вы проиграли! Попробуйте снова.";

            MessageBox.Show(message, "ИГРА");

            foreach (var box in boxes)
            {
                box.Dispose();
            }

            boxes = null;
            timer1.Stop();
            label2.Visible = false;

            if (Master.supabaseClient.Auth.CurrentUser != null)
            {
                var game = new Types.Game
                {
                    User = Master.supabaseClient.Auth.CurrentUser.Id,
                    PlayedDifficulty = selectedDifficulty.Name,
                    IsWon = isWin,
                    TimeTaken = (int)(selectedDifficulty.TimeLimit - _leftTime).TotalSeconds,
                    Name = $"Игра от {DateTime.Now}"
                };
                await GameGetterHelper.PostNewGame(game);
            }
            else
            {
                message += "\n\nВойдите, чтобы сохранить результат!";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var optionsForm = new OptionsMenu(this);
            optionsForm.ShowDialog();
        }
    }



    public class Difficulty
    {
        public string Name = "Standard";

        public Color DiffColor;
        public TimeSpan TimeLimit { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public Difficulty(string name, TimeSpan timeLimit, Color diffColor)
        {
            Name = name;
            TimeLimit = timeLimit;
            DiffColor = diffColor;
        }

        public static readonly List<Difficulty> Difficulties = new List<Difficulty>
        {
            new Difficulty("Easy", TimeSpan.FromMinutes(5), Color.Green),
            new Difficulty("Medium", TimeSpan.FromMinutes(3), Color.Yellow),
            new Difficulty("Hard", TimeSpan.FromMinutes(1), Color.Red)
        };
    }
}

            
