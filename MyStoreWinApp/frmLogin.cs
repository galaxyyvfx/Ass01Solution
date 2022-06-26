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

        Member loginMember = memberServices.Login(email, password);
        if (loginMember != null)
        {
            frmManagement frmManagement = new frmManagement(loginMember);
            this.Close();
        }
        else
        {
            MessageBox.Show("Incorrect Email or Password!");
        }
    }
}
