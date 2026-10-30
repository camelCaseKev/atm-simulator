namespace ATM_Simulator___GUI
{
    using static Account;
    using static Program;
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ATM_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool userExists = false;
            int selectedAcct = -1;

            for(int i = 0; i < accounts.Length; ++i)
            {
                if(txtUsername.Text == accounts[i].User)
                {
                    //selectedAcct = i;
                    selectedIndex = i;
                    userExists = true;
                }
            }

            if(userExists && txtPassword.Text == accounts[selectedIndex].Pass)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            } else
            {
                lblLoginFeedback.Visible = true;
            }
        }
    }
}