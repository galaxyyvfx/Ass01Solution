using BusinessObject.Services;

using DataAccess.Entities;
using Microsoft.Extensions.Configuration;

namespace MyStoreWinApp;

public partial class frmManagement : Form
{
    private Member loginMember;
    private MemberServices memberServices = new MemberServices();

    private bool IsAdmin = false;
    Dictionary<string, string[]> CountryToCity = new Dictionary<string, string[]>();

    private BindingSource source;
    private void ClearText()
    {
        // CODE HERE
        txtMemberId.Text = string.Empty;
        txtMemberName.Text = string.Empty;
        cboCity.SelectedIndex = 0;
        cboCountry.SelectedIndex = 0;
    }
    private void CheckAuthentication()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("AppSettings.json", true, true)
            .Build();

        string adminEmail = config["DefaultAccounts:Email"];

        if (loginMember.Email == adminEmail)
        {
            IsAdmin = true;
        }
    }
    private Member GetMemberObject()
    {
        Member member = null;
        try
        {
            var currentRow = dgvMemberList.CurrentRow;
            member = new Member
            {
                MemberID = Convert.ToInt32(currentRow.Cells[0].Value),
                MemberName = currentRow.Cells[1].Value.ToString(),
                Email = currentRow.Cells[2].Value.ToString(),
                Password = currentRow.Cells[3].Value.ToString(),
                City = currentRow.Cells[4].Value.ToString(),
                Country = currentRow.Cells[5].Value.ToString(),
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
            if (IsAdmin == false)
            {
                source.DataSource =
                    new[] { memberServices.SearchMemberById(loginMember.MemberID) };
            }
            else
            {
                source.DataSource = list;
            }

            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = source;

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

        CountryToCity[""] = new string[] {
                "",
                "Hanoi",
                "Ho Chi Minh",
                "Da Nang",
                "Hue",
                "New York",
                "Washington",
                "Los Angeles",
                "San Francisco",
                "Las Vegas",
                "Chicago",
                "Shanghai",
                "Beijing",
                "Guangzhou",
                "Tianjin",
                "Chongqing",
                "Sydney",
                "Melbourne",
                "Perth",
                "Brisbane",
            };
        CountryToCity["Vietnam"] = new string[] {
                "",
                "Hanoi",
                "Ho Chi Minh",
                "Da Nang",
                "Hue",
            };
        CountryToCity["America"] = new string[] {
                "",
                "New York",
                "Washington",
                "Los Angeles",
                "San Francisco",
                "Las Vegas",
                "Chicago",
            };
        CountryToCity["China"] = new string[]
        {
                "",
                "Shanghai",
                "Beijing",
                "Guangzhou",
                "Tianjin",
                "Chongqing",
        };
        CountryToCity["Australia"] = new string[]
        {
                "",
                "Sydney",
                "Melbourne",
                "Perth",
                "Brisbane",
        };
    }

    private void frmManagement_Load(object sender, EventArgs e)
    {
        CheckAuthentication();

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
        if (!string.IsNullOrEmpty(txtMemberId.Text))
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
                var searchCity = memberServices.FilterMemberByCity(cboCity.Text);
                var searchCountry = memberServices.FilterMemberByCountry(cboCountry.Text);
                var resultSet = from names in searchNames
                                join cities in searchCity
                                    on names.MemberID equals cities.MemberID
                                join countries in searchCountry
                                    on names.MemberID equals countries.MemberID
                                select new Member
                                {
                                    MemberID = names.MemberID,
                                    MemberName = names.MemberName,
                                    City = names.City,
                                    Country = names.Country,
                                    Email = names.Email,
                                    Password = names.Password,
                                };
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
