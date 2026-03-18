using SupabaseReg.Extensions;

namespace SupabaseReg;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }


    private void button2_Click(object sender, EventArgs e)
    {
        RegisterForm  registerForm = new RegisterForm();
        registerForm.ShowDialog();
        ShowAvatar();
    }

    private async void ShowAvatar()
    {
        if (Master.supabaseClient.Auth.CurrentUser == null) return;
        
        var file = await LoginManager.GetAvatarFile(Master.supabaseClient.Auth.CurrentUser);
        if (file == null) return;
        var img = Image.FromFile(file);
        pictureBox1.Image = img;
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        LoginForm loginForm = new LoginForm();
        loginForm.ShowDialog();
        ShowAvatar();
    }
}