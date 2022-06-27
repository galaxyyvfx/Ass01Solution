using BusinessObject.Services;

using DataAccess.Entities;

namespace MyStoreWinApp;

public partial class frmManagement : Form
{
    private Member loginMember;
    private MemberServices memberServices = new MemberServices();

    Dictionary<string, string[]> CountryToCity = new Dictionary<string, string[]>();

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
            if (list.Count() > 0)
            {
                source = new BindingSource();
                source.DataSource = list;

                txtMemberId.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                cboCity.DataBindings.Clear();
                cboCountry.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                cboCity.DataBindings.Add("Text", source, "City");
                cboCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = list;


                btnDelete.Enabled = true;
            }
            else
            {
                ClearText();
                btnDelete.Enabled = false;
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

        CountryToCity["Vietnam"] = new string[] {
                "Hanoi",
                "Ho Chi Minh",
                "Da Nang",
                "Hue",
            };
        CountryToCity["America"] = new string[] {
                "New York",
                "Washington",
                "Los Angeles",
                "San Francisco",
                "Las Vegas",
                "Chicago",
            };
        CountryToCity["China"] = new string[]
        {
                "Shanghai",
                "Beijing",
                "Guangzhou",
                "Tianjin",
                "Chongqing",
        };
        CountryToCity["Australia"] = new string[]
        {
                "Sydney",
                "Melbourne",
                "Perth",
                "Brisbane",
        };
    }

    private void frmManagement_Load(object sender, EventArgs e)
    {
        btnDelete.Enabled = false;

        cboCountry.SelectedIndex = 0;
        LoadCityComboBox();

        var memberList = memberServices.GetMemberList();
        LoadMemberList(memberList);
        dgvMemberList.CellDoubleClick += DgvMemberList_CellDoubleClick;
    }
    private void DgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        frmDetails details = new frmDetails
        {
            Text = "Update Member",
            IsUpdate = true,
            memberInfo = GetMemberObject(),
            memberServices = memberServices,
        };
        if (details.ShowDialog() == DialogResult.OK)
        {
            var memberList = memberServices.GetMemberList();
            LoadMemberList(memberList);
            source.Position = source.Count - 1;
        }
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
        frmDetails details = new frmDetails
        {
            Text = "Add member",
            IsUpdate = false,
            memberServices = memberServices,
        };
        if (details.ShowDialog() == DialogResult.OK)
        {
            var memberList = memberServices.GetMemberList();
            LoadMemberList(memberList);
            source.Position = source.Count - 1;
        }
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

    private void LoadCityComboBox()
    {
        cboCity.Items.Clear();
        if (cboCountry.SelectedIndex >= 0)
        {
            string country = cboCountry.Text;
            foreach (string city in CountryToCity[country])
            {
                cboCity.Items.Add(city);
            }
            cboCity.SelectedIndex = 0;
        }
    }
    private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadCityComboBox();
    }
}
