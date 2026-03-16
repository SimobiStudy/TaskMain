using System.ComponentModel;

namespace SupabaseReg;

partial class RegisterForm
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
        textBoxLogin = new System.Windows.Forms.TextBox();
        textBoxPassword = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // textBoxLogin
        // 
        textBoxLogin.Location = new System.Drawing.Point(32, 56);
        textBoxLogin.Name = "textBoxLogin";
        textBoxLogin.Size = new System.Drawing.Size(195, 27);
        textBoxLogin.TabIndex = 0;
        // 
        // textBoxPassword
        // 
        textBoxPassword.Location = new System.Drawing.Point(32, 114);
        textBoxPassword.Name = "textBoxPassword";
        textBoxPassword.Size = new System.Drawing.Size(195, 27);
        textBoxPassword.TabIndex = 1;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(32, 30);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 2;
        label1.Text = "Логин";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(32, 88);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 3;
        label2.Text = "Пароль";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(43, 274);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(165, 81);
        button1.TabIndex = 4;
        button1.Text = "Зарегистрироваться";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new System.Drawing.Point(179, 172);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(80, 80);
        pictureBox1.TabIndex = 5;
        pictureBox1.TabStop = false;
        // 
        // RegisterForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(271, 450);
        Controls.Add(pictureBox1);
        Controls.Add(button1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textBoxPassword);
        Controls.Add(textBoxLogin);
        Text = "Регистрация";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox textBoxLogin;
    private System.Windows.Forms.TextBox textBoxPassword;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    #endregion
}