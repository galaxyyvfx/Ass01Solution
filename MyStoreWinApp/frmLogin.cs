using BusinessObject;
using BusinessObject.Services;
using DataAccess.Entities;

namespace MyStoreWinApp;

public partial class frmLogin : Form
{
    IMemberServices memberServices = new MemberServices();
    public frmLogin()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string password = txtPassword.Text;

        try
        {
            Member loginMember = memberServices.Login(email, password);
            if (loginMember != null)
            {
                this.Hide();
                frmManagement frmManagement = new frmManagement(loginMember);
                frmManagement.ShowDialog();
                this.Show();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Login");
        }
    }
}
