using System.ComponentModel;
using System.Text.RegularExpressions;
using Supabase.Gotrue.Exceptions;
using SupabaseReg.Extensions;

namespace SupabaseReg;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private const string emailRegexValidation = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

    private void textBox1_Validating(object sender, CancelEventArgs e)
    {
        TextBox textBox =  (TextBox) sender;
        if (!Regex.IsMatch(textBox.Text, emailRegexValidation))
            e.Cancel = true;
    }

    private async void buttonLogin_Click(object sender, EventArgs e)
    {
        var email = textBox1.Text;
        var password = textBoxPassword.Text;
        try
        {
            await LoginManager.LoginToUser(email, password);
        }
        catch (GotrueException gotrueException)
        {
            if (gotrueException.StatusCode >= 400 &&  gotrueException.StatusCode <= 403)
                MessageBox.Show("Неверная почта или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                throw gotrueException;
            }
            return;
        }
        if (Master.supabaseClient.Auth.CurrentSession == null)
        {
            MessageBox.Show("Неверная почта или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        MessageBox.Show("Успешный вход!", "Усп", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
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