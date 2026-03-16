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
        textBoxLogin = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        textBoxPassword = new System.Windows.Forms.TextBox();
        buttonLogin = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBoxLogin
        // 
        textBoxLogin.Location = new System.Drawing.Point(33, 45);
        textBoxLogin.Name = "textBoxLogin";
        textBoxLogin.Size = new System.Drawing.Size(148, 27);
        textBoxLogin.TabIndex = 0;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(33, 19);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 1;
        label1.Text = "Логин";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(33, 88);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 2;
        label2.Text = "Пароль";
        // 
        // textBoxPassword
        // 
        textBoxPassword.Location = new System.Drawing.Point(33, 114);
        textBoxPassword.Name = "textBoxPassword";
        textBoxPassword.Size = new System.Drawing.Size(148, 27);
        textBoxPassword.TabIndex = 3;
        // 
        // buttonLogin
        // 
        buttonLogin.Location = new System.Drawing.Point(33, 163);
        buttonLogin.Name = "buttonLogin";
        buttonLogin.Size = new System.Drawing.Size(148, 44);
        buttonLogin.TabIndex = 4;
        buttonLogin.Text = "Войти";
        buttonLogin.UseVisualStyleBackColor = true;
        buttonLogin.Click += buttonLogin_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(597, 450);
        Controls.Add(buttonLogin);
        Controls.Add(textBoxPassword);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textBoxLogin);
        Text = "Форма входа";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBoxLogin;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxPassword;
    private System.Windows.Forms.Button buttonLogin;

    #endregion
}