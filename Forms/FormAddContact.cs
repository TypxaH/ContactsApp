using ContactsApp.Services;
namespace ContactsApp
{
    public partial class FormAddContact : Form
    {
        public string ContactName => this.textBoxName.Text;
        public string ContactPhone => this.textBoxPhone.Text;

        public FormAddContact()
        {
            InitializeComponent();         
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
                       
            if (!Validator.IsValidName(ContactName,out string messageNameError))
            {
                MessageBox.Show(messageNameError, "Грешка в името", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Validator.IsValidNumber(ContactPhone, out string messageNumberError))
            {
                MessageBox.Show(messageNumberError, "Грешка в номера", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancelAddContact_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
