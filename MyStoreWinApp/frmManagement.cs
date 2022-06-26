using BusinessObject.Services;

using DataAccess.Entities;

namespace MyStoreWinApp;

public partial class frmManagement : Form
{
    private Member loginMember;
    private MemberServices memberServices = new MemberServices();

    private BindingSource source;
    private void ClearText()
    {
        // CODE HERE
    }
    public void LoadMemberList()
    {
        // CODE HERE
    }
    
    public frmManagement(Member loginMember)
    {
        this.loginMember = loginMember;
        InitializeComponent();
    }

    private void frmManagement_Load(object sender, EventArgs e)
    {
        // CODE HERE    
    }
}
