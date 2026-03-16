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
            MessageBox.Show($"Пользователь {newUser.Username} успешно создан", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}