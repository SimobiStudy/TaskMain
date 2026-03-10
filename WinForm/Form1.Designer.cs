namespace WinForm;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm.Form1));
        pictureBox1 = new System.Windows.Forms.PictureBox();
        label1 = new System.Windows.Forms.Label();
        numericUpDown1 = new WinForm.NumericUpDownPrecision();
        label2 = new System.Windows.Forms.Label();
        numericUpDown2 = new System.Windows.Forms.NumericUpDown();
        button1 = new System.Windows.Forms.Button();
        label3 = new System.Windows.Forms.Label();
        labelResult = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        SuspendLayout();
        pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(12, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(540, 71);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        label1.Location = new System.Drawing.Point(12, 106);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(175, 24);
        label1.TabIndex = 1;
        label1.Text = "Точность вычислений:";
        numericUpDown1.DecimalPlaces = 8;
        numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 327680 });
        numericUpDown1.InterceptArrowKeys = false;
        numericUpDown1.Location = new System.Drawing.Point(12, 133);
        numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new System.Drawing.Size(175, 27);
        numericUpDown1.TabIndex = 2;
        numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 327680 });
        label2.Location = new System.Drawing.Point(363, 106);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(133, 24);
        label2.TabIndex = 3;
        label2.Text = "Аргумент X:";
        numericUpDown2.DecimalPlaces = 2;
        numericUpDown2.Location = new System.Drawing.Point(363, 133);
        numericUpDown2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        numericUpDown2.Minimum = new decimal(new int[] { 10000, 0, 0, -2147483648 });
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new System.Drawing.Size(175, 27);
        numericUpDown2.TabIndex = 4;
        numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 327680 });
        button1.Location = new System.Drawing.Point(209, 171);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(130, 48);
        button1.TabIndex = 5;
        button1.Text = "Вычислить";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label3.Location = new System.Drawing.Point(12, 235);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(141, 34);
        label3.TabIndex = 6;
        label3.Text = "Результат:";
        labelResult.Location = new System.Drawing.Point(39, 283);
        labelResult.Name = "labelResult";
        labelResult.Size = new System.Drawing.Size(481, 149);
        labelResult.TabIndex = 7;
        labelResult.Text = "label4";
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(564, 455);
        Controls.Add(labelResult);
        Controls.Add(label3);
        Controls.Add(button1);
        Controls.Add(numericUpDown2);
        Controls.Add(label2);
        Controls.Add(numericUpDown1);
        Controls.Add(label1);
        Controls.Add(pictureBox1);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label labelResult;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.NumericUpDown numericUpDown2;

    private System.Windows.Forms.Label label1;
    private NumericUpDownPrecision numericUpDown1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
}