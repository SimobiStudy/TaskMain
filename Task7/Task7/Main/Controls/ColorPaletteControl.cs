using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Task7.Main.Controls
{
    public partial class ColorPaletteControl : UserControl
    {
       
        public event EventHandler<Color> ColorChanged;

        public Color SelectedColor
        {
            get { return selectedColor; }
        }

        private Color selectedColor = Color.Black; 

        public ColorPaletteControl()
        {
            InitializeComponent();

            // Настройка индикатора текущего цвета
            buttonCurrentColor.BackColor = selectedColor;
            buttonCurrentColor.FlatStyle = FlatStyle.Flat;
            buttonCurrentColor.FlatAppearance.BorderSize = 0; 

            // Создаем сетку цветов
            GenerateColorGrid();
        }

        // Метод для создания кнопок цветов
        private void GenerateColorGrid()
        {
            // Массив предустановленных цветов, как на скриншоте
            Color[,] colors = new Color[,]
            {
            { Color.Black, Color.FromArgb(64,64,64), Color.Gray, Color.FromArgb(128,0,0), Color.Red, Color.Orange, Color.Yellow, Color.FromArgb(192,255,0), Color.Green, Color.Blue, Color.FromArgb(0,0,128), Color.Purple },
            { Color.White, Color.Silver, Color.FromArgb(224,224,224), Color.FromArgb(165,42,42), Color.Pink, Color.Beige, Color.LightYellow, Color.PaleGreen, Color.Olive, Color.Cyan, Color.FromArgb(70,130,180), Color.FromArgb(230,230,250) }
            };

            int rows = colors.GetLength(0);
            int cols = colors.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    // Создаем маленькую кнопку для каждого цвета
                    Button btn = new Button();
                    btn.Size = new Size(25, 25); // Размер маленькой ячейки
                    btn.BackColor = colors[r, c];
                    btn.FlatStyle = FlatStyle.Standard;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Margin = new Padding(1); // Небольшой отступ

                    // При клике на маленькую кнопку вызывается обработчик
                    btn.Click += ColorGridButton_Click;

                    // Добавляем кнопку в сетку
                    flowLayoutPanelGrid.Controls.Add(btn);
                }
            }
        }

        // Обработчик клика на маленькую цветную кнопку
        private void ColorGridButton_Click(object sender, EventArgs e)
        {
            // Получаем цвет нажатой кнопки
            Color newColor = ((Button)sender).BackColor;

            // Обновляем индикатор
            selectedColor = newColor;
            buttonCurrentColor.BackColor = newColor;

            // Генерируем событие для главной формы
            ColorChanged?.Invoke(this, newColor);
        }
    }
}
