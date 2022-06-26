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
        txtMemberId.Text = string.Empty;
        txtMemberName.Text = string.Empty;
        txtEmail.Text = string.Empty;
        txtPassword.Text = string.Empty;
        cboCity.SelectedIndex = 0;
        cboCountry.SelectedIndex = 0;
    }
    private Member GetMemberObject()
    {
        Member member = null;
        try
        {
            member = new Member
            {
                MemberID = int.Parse(txtMemberId.Text),
                MemberName = txtMemberName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                City = cboCity.Text,
                Country = cboCountry.Text,
            };
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Get member");
        }
        return member;
    }
    public void LoadMemberList(IEnumerable<Member> list)
    {
        // CODE HERE
        try
        {
            source = new BindingSource();
            source.DataSource = list;

            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = list;
            if (list.Count() == 0)
            {
                ClearText();
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Load car list");
        }
    }
    
    public frmManagement(Member loginMember)
    {
        this.loginMember = loginMember;
        InitializeComponent();
    }

    private void frmManagement_Load(object sender, EventArgs e)
    {
        btnDelete.Enabled = false;
        var memberList = memberServices.GetMemberList();
        LoadMemberList(memberList);
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            Member member = GetMemberObject();
            memberServices.DeleteMember(member.MemberID);
            var memberList = memberServices.GetMemberList();
            LoadMemberList(memberList);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Delete member");
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtMemberId.Text))
        {
            try
            {
                Member searchMember = memberServices.SearchMemberById(
                    int.Parse(txtMemberId.Text));
                LoadMemberList(new [] {searchMember});
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search by ID");
            }
        }
        else
        {
            try
            {
                var searchNames = memberServices.SearchMemberByName(txtMemberName.Text);
                var searchCity = memberServices.FilterMemberByCity(cboCity.Text.Trim());
                var searchCountry = memberServices.FilterMemberByCountry(cboCountry.Text.Trim());
                var resultSet = from names in searchNames
                                join cities in searchCity
                                    on names.MemberID equals cities.MemberID
                                join countries in searchCountry
                                    on names.MemberID equals countries.MemberID
                                select names;
                LoadMemberList(resultSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search error");
            }
        }
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
