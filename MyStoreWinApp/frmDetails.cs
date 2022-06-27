using BusinessObject;
using DataAccess.Entities;

namespace MyStoreWinApp
{
    public partial class frmDetails : Form
    {
        public IMemberServices memberServices { get; set; }

        public bool IsUpdate { get; set; }
        public Member memberInfo { get; set; }

        Dictionary<string, string[]> CountryToCity = new Dictionary<string, string[]>();
        public frmDetails()
        {
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

        private void frmDetails_Load(object sender, EventArgs e)
        {
            cboCountry.SelectedIndex = 0;
            LoadCityComboBox();
            if (IsUpdate == true)
            {
                txtMemberId.Text = memberInfo.MemberID.ToString();
                txtMemberName.Text = memberInfo.MemberName;
                txtEmail.Text = memberInfo.Email;
                txtPassword.Text = memberInfo.Password;
                cboCity.Text = memberInfo.City;
                cboCountry.Text = memberInfo.Country;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member
                {
                    MemberID = int.Parse(txtMemberId.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = cboCity.Text,
                    Country = cboCountry.Text,
                };
                if (IsUpdate == false)
                {
                    memberServices.CreateMember(member);
                }
                else
                {
                    memberServices.UpdateMember(member);
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, IsUpdate==false?"Add Member":"Update Member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

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

        private void lblCountry_Click(object sender, EventArgs e)
        {

        }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblMemberName_Click(object sender, EventArgs e)
        {

        }

    }
}
