namespace Task7
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelCanvas = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            квадратПрямоугольникToolStripMenuItem = new ToolStripMenuItem();
            прямоугольникСДыркойToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            labelWidth = new Label();
            saveFileInfo = new SaveFileDialog();
            openFileInfo = new OpenFileDialog();
            colorPaletteControl1 = new Task7.Main.Controls.ColorPaletteControl();
            trackBar1 = new TrackBar();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // panelCanvas
            // 
            panelCanvas.Location = new Point(76, 56);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(1161, 464);
            panelCanvas.TabIndex = 0;
            panelCanvas.Paint += panelCanvas_Paint;
            panelCanvas.MouseDoubleClick += panelCanvas_MouseDoubleClick;
            panelCanvas.MouseDown += panelCanvas_MouseDown;
            panelCanvas.MouseMove += panelCanvas_MouseMove;
            panelCanvas.MouseUp += panelCanvas_MouseUp;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripButton2, toolStripButton3, toolStripSeparator1, toolStripButton4 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1338, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { квадратПрямоугольникToolStripMenuItem, прямоугольникСДыркойToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(34, 24);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // квадратПрямоугольникToolStripMenuItem
            // 
            квадратПрямоугольникToolStripMenuItem.Name = "квадратПрямоугольникToolStripMenuItem";
            квадратПрямоугольникToolStripMenuItem.Size = new Size(273, 26);
            квадратПрямоугольникToolStripMenuItem.Text = "Квадрат (Прямоугольник)";
            квадратПрямоугольникToolStripMenuItem.Click += квадратПрямоугольникToolStripMenuItem_Click;
            // 
            // прямоугольникСДыркойToolStripMenuItem
            // 
            прямоугольникСДыркойToolStripMenuItem.Name = "прямоугольникСДыркойToolStripMenuItem";
            прямоугольникСДыркойToolStripMenuItem.Size = new Size(273, 26);
            прямоугольникСДыркойToolStripMenuItem.Text = "Прямоугольник с дыркой";
            прямоугольникСДыркойToolStripMenuItem.Click += прямоугольникСДыркойToolStripMenuItem_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 24);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1338, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem, открытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(192, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(192, 26);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            сохранитьКакToolStripMenuItem.Click += сохранитьКакToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(192, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(74, 24);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWidth.Location = new Point(748, 583);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(136, 18);
            labelWidth.TabIndex = 6;
            labelWidth.Text = "Толщина линии";
            // 
            // saveFileInfo
            // 
            saveFileInfo.DefaultExt = "cnvs";
            saveFileInfo.FileName = "canvas";
            saveFileInfo.Filter = "cnvs Файлы|*.cnvs|Все файлы|*.*";
            saveFileInfo.Title = "Сохранить в файл";
            // 
            // openFileInfo
            // 
            openFileInfo.DefaultExt = "cnvs";
            openFileInfo.FileName = "canvas";
            openFileInfo.Filter = "cnvs Файлы|*.cnvs|Все файлы|*.*";
            // 
            // colorPaletteControl1
            // 
            colorPaletteControl1.Location = new Point(150, 577);
            colorPaletteControl1.Name = "colorPaletteControl1";
            colorPaletteControl1.Size = new Size(428, 67);
            colorPaletteControl1.TabIndex = 7;
            colorPaletteControl1.ColorChanged += colorPaletteControl1_ColorChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(899, 577);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(238, 56);
            trackBar1.SmallChange = 2;
            trackBar1.TabIndex = 8;
            trackBar1.Value = 2;
            trackBar1.ValueChanged += trackBar1_Scroll;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 677);
            Controls.Add(trackBar1);
            Controls.Add(colorPaletteControl1);
            Controls.Add(labelWidth);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(panelCanvas);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Простой векторный графический редактор";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelCanvas;
        private ToolStrip toolStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private Label labelWidth;
        private SaveFileDialog saveFileInfo;
        private OpenFileDialog openFileInfo;
        private Main.Controls.ColorPaletteControl colorPaletteControl1;
        private TrackBar trackBar1;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton4;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem квадратПрямоугольникToolStripMenuItem;
        private ToolStripMenuItem прямоугольникСДыркойToolStripMenuItem;
    }
}
