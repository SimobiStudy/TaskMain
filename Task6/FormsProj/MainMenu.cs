namespace FormsProj;

public partial class MainMenu : Form
{
    public MainMenu()
    {
        InitializeComponent();
    }

    private void buttonUser_Click(object sender, EventArgs e)
    {
        var formUser = new FormProj();
        formUser.Show();
        
        this.Hide();
        formUser.Disposed += ReturnOnFormClosed;
    }
    
    private void buttonAdmin_Click(object sender, EventArgs e)
    {
        var formAdmin = new FormEdit();
        formAdmin.Show();
        
        this.Hide();
        formAdmin.Disposed += ReturnOnFormClosed;
    }

    private void ReturnOnFormClosed(object? sender, EventArgs e)
    {
        this.Show();
    }
}