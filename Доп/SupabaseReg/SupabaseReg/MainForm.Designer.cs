using System.ComponentModel;

namespace SupabaseReg;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        pictureBox1 = new System.Windows.Forms.PictureBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pictureBox1.Location = new System.Drawing.Point(408, 19);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(150, 150);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 5;
        pictureBox1.TabStop = false;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(27, 19);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(103, 33);
        button1.TabIndex = 6;
        button1.Text = "Вход";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(166, 19);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(136, 33);
        button2.TabIndex = 7;
        button2.Text = "Регистрация";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(597, 450);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(pictureBox1);
        Location = new System.Drawing.Point(19, 19);
        Text = "Форма входа";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
}