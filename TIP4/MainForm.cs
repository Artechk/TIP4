namespace TIP4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCheckPassword_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            var validator = new PasswordValidator();

            if (validator.Validate(password, out string errorMessage))
            {
                MessageBox.Show("������ ������� ������ ��������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(errorMessage, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
