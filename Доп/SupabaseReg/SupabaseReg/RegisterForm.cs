using System.ComponentModel;
using System.Text.RegularExpressions;

namespace SupabaseReg;

public partial class RegisterForm : Form
{
    public RegisterForm()
    {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        var newUser = await LoginManager.RegisterNewUser(textBoxLogin.Text, textBoxPassword.Text);
        if (pictureBox1.Tag is string tag && tag != null)
            await LoginManager.UploadAvatar(tag, newUser);
        if (newUser != null)
        {
            MessageBox.Show($"Пользователь {newUser.Id} успешно создан", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Ошибка при создании пользователя.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = openFileDialog1.ShowDialog();
        if (dialogResult != DialogResult.OK) return;
        Image img;
        try
        {
            img = Image.FromFile(openFileDialog1.FileName);
        }
        catch
        {
            MessageBox.Show("Выбранный файл не является картинкой", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        pictureBox1.Image = img;
        pictureBox1.Tag = openFileDialog1.FileName;
    }


    private const string emailRegexValidation = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

    private void textBoxLogin_Validating(object sender, CancelEventArgs e)
    {
        TextBox textBox =  (TextBox) sender;
        if (!Regex.IsMatch(textBox.Text, emailRegexValidation))
            e.Cancel = true;
    }
    

    private void textBoxPassword_Validating(object sender, CancelEventArgs e)
    {
        TextBox textBox = (TextBox) sender;
        if (textBox.Text.Length < 8)
        {
            MessageBox.Show("Пароль должен быть размером не менее 8 символов", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }
    }
}