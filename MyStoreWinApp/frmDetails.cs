using BusinessObject;
using DataAccess.Entities;

namespace MyStoreWinApp
{
    public partial class frmDetails : Form
    {
        public IMemberServices memberServices { get; set; }

        public bool IsUpdate { get; set; }
        public Member memberInfo { get; set; }
        public frmDetails()
        {
            InitializeComponent();
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            cboCity.SelectedIndex = 0;
            cboCountry.SelectedIndex = 0;
            if (IsUpdate == true)
            {
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

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

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
