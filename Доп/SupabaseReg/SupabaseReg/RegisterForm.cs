namespace SupabaseReg;

public partial class RegisterForm : Form
{
    public RegisterForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var login = LoginManager.RegisterNewUser(textBoxLogin.Text, textBoxPassword.Text).GetAwaiter().GetResult();

        if (login != null)
        {
            MessageBox.Show($"Пользователь {login.Username} успешно создан", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Ошибка при создании пользователя.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}