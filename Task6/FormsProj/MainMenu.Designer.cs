using System.ComponentModel;

namespace FormsProj;

partial class MainMenu
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(MainMenu));
        labelText = new Label();
        buttonUser = new Button();
        buttonAdmin = new Button();
        SuspendLayout();
        // 
        // labelText
        // 
        labelText.Font = new Font("Roboto Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
        labelText.Location = new Point(12, 28);
        labelText.Name = "labelText";
        labelText.Size = new Size(590, 171);
        labelText.TabIndex = 0;
        labelText.Text = resources.GetString("labelText.Text");
        // 
        // buttonUser
        // 
        buttonUser.Font = new Font("Helvetica", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
        buttonUser.Location = new Point(46, 289);
        buttonUser.Name = "buttonUser";
        buttonUser.Size = new Size(158, 66);
        buttonUser.TabIndex = 1;
        buttonUser.Text = "Зайти как пользователь";
        buttonUser.UseVisualStyleBackColor = true;
        buttonUser.Click += buttonUser_Click;
        // 
        // buttonAdmin
        // 
        buttonAdmin.Font = new Font("Helvetica", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
        buttonAdmin.Location = new Point(360, 289);
        buttonAdmin.Name = "buttonAdmin";
        buttonAdmin.Size = new Size(158, 66);
        buttonAdmin.TabIndex = 2;
        buttonAdmin.Text = "Зайти как администратор";
        buttonAdmin.UseVisualStyleBackColor = true;
        buttonAdmin.Click += buttonAdmin_Click;
        // 
        // MainMenu
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.LightCyan;
        ClientSize = new Size(614, 450);
        Controls.Add(buttonAdmin);
        Controls.Add(buttonUser);
        Controls.Add(labelText);
        Name = "MainMenu";
        Text = "Главное меню";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button buttonUser;

    private System.Windows.Forms.Button buttonAdmin;

    private System.Windows.Forms.Label labelText;

    #endregion
}