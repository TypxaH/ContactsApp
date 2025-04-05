using ContactsApp.Services;

namespace ContactsApp
{
    public partial class FormContacts : Form
    {
        private readonly ContactServices contactServices;
        public FormContacts()
        {
            InitializeComponent();
            contactServices = new ContactServices();
        }

        private void FormContacts_Load(object sender, EventArgs e)
        {
            ReloadContacts();
        }

        private void ReloadContacts()
        {
            contactBindingSource.DataSource = contactServices.LoadContactsFromDb();
        }

        private void buttonAddContactMain_Click(object sender, EventArgs e)
        {
            var formAddContact = new FormAddContact();

            if(formAddContact.ShowDialog()==DialogResult.OK)
            {
                contactServices.AddNewContact(formAddContact.ContactName, formAddContact.ContactPhone);
                ReloadContacts();
            }
        }
    }
}
