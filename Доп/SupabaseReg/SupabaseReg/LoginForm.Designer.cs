using System.ComponentModel;

namespace SupabaseReg;

partial class LoginForm
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
        label1 = new System.Windows.Forms.Label();
        labelLogin = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        labelPassword = new System.Windows.Forms.Label();
        textBoxPassword = new System.Windows.Forms.TextBox();
        buttonLogin = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(42, 8);
        label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(12, 8);
        label1.TabIndex = 0;
        label1.Text = "label1";
        // 
        // labelLogin
        // 
        labelLogin.Location = new System.Drawing.Point(35, 15);
        labelLogin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        labelLogin.Name = "labelLogin";
        labelLogin.Size = new System.Drawing.Size(322, 34);
        labelLogin.TabIndex = 1;
        labelLogin.Text = "Электронная почта (Email)";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(42, 48);
        textBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(284, 27);
        textBox1.TabIndex = 2;
        textBox1.Validating += textBox1_Validating;
        // 
        // labelPassword
        // 
        labelPassword.Location = new System.Drawing.Point(45, 94);
        labelPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        labelPassword.Name = "labelPassword";
        labelPassword.Size = new System.Drawing.Size(156, 23);
        labelPassword.TabIndex = 3;
        labelPassword.Text = "Пароль";
        // 
        // textBoxPassword
        // 
        textBoxPassword.Location = new System.Drawing.Point(42, 132);
        textBoxPassword.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
        textBoxPassword.Name = "textBoxPassword";
        textBoxPassword.Size = new System.Drawing.Size(284, 27);
        textBoxPassword.TabIndex = 4;
        textBoxPassword.Validating += textBoxPassword_Validating;
        // 
        // buttonLogin
        // 
        buttonLogin.Location = new System.Drawing.Point(44, 190);
        buttonLogin.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
        buttonLogin.Name = "buttonLogin";
        buttonLogin.Size = new System.Drawing.Size(285, 70);
        buttonLogin.TabIndex = 5;
        buttonLogin.Text = "Войти";
        buttonLogin.UseVisualStyleBackColor = true;
        buttonLogin.Click += buttonLogin_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.LightGray;
        ClientSize = new System.Drawing.Size(376, 302);
        Controls.Add(buttonLogin);
        Controls.Add(textBoxPassword);
        Controls.Add(labelPassword);
        Controls.Add(textBox1);
        Controls.Add(labelLogin);
        Controls.Add(label1);
        Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Text = "Вход";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBoxPassword;
    private System.Windows.Forms.Button buttonLogin;

    private System.Windows.Forms.Label labelPassword;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labelLogin;
    private System.Windows.Forms.TextBox textBox1;

    #endregion
}