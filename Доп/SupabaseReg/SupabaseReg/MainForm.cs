namespace SupabaseReg;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private async void buttonLogin_Click(object sender, EventArgs e)
    {
        var login = await LoginManager.GetLoginResult(textBoxLogin.Text, textBoxPassword.Text);
        
        if (login != null)
        {
            MessageBox.Show("Верный логин!", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var avatarFile = await LoginManager.GetAvatarFile(login);
            if (avatarFile == null) return;
            Image avatarImg = Image.FromFile(avatarFile);
            pictureBox1.Image = avatarImg;
        }
        else
        {
            MessageBox.Show("Неверный логин или пароль!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var regForm = new RegisterForm();
        regForm.ShowDialog();
    }
}