using System.Drawing.Drawing2D;

namespace Task7.Main.Controls
{
    partial class ColorPaletteControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelGrid = new FlowLayoutPanel();
            buttonCurrentColor = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanelGrid
            // 
            flowLayoutPanelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelGrid.AutoSize = true;
            flowLayoutPanelGrid.BackColor = Color.FromArgb(240, 240, 240);
            flowLayoutPanelGrid.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelGrid.Location = new Point(44, 0);
            flowLayoutPanelGrid.Name = "flowLayoutPanelGrid";
            flowLayoutPanelGrid.Size = new Size(348, 79);
            flowLayoutPanelGrid.TabIndex = 0;
            // 
            // buttonCurrentColor
            // 
            buttonCurrentColor.AutoSize = true;
            buttonCurrentColor.Location = new Point(3, 13);
            buttonCurrentColor.Name = "buttonCurrentColor";
            buttonCurrentColor.Size = new Size(35, 35);
            buttonCurrentColor.TabIndex = 0;
            buttonCurrentColor.UseVisualStyleBackColor = true;
            // 
            // ColorPaletteControl
            // 
            Controls.Add(buttonCurrentColor);
            Controls.Add(flowLayoutPanelGrid);
            Name = "ColorPaletteControl";
            Size = new Size(392, 79);
            ResumeLayout(false);
            PerformLayout();

        }

        // Переопределяем отрисовку, чтобы нарисовать пунктирную линию слева
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(Color.Gray, 1))
            {
                pen.DashStyle = DashStyle.Dot; // Пунктирный стиль

                // Рисуем вертикальную линию
                e.Graphics.DrawLine(pen, 5, 5, 5, this.Height - 5);
            }
        }

        private FlowLayoutPanel flowLayoutPanelGrid;
        private Button buttonCurrentColor;
    }

        #endregion
}
