namespace SupabaseReg;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void buttonLogin_Click(object sender, EventArgs e)
    {
        var login = LoginManager.GetLoginResult(textBoxLogin.Text, textBoxPassword.Text).GetAwaiter().GetResult();

        if (login)
        {
            MessageBox.Show("Верный логин!", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Неверный логин или пароль!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}