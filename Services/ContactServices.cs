using ContactsApp.Models;

namespace ContactsApp.Services
{
    public class ContactServices
    {
        public void AddNewContact(string contactName, string contactPhone)
        {
            using (var context = new ContactsDbContext())
            {
                Contact newContact = new Contact();
                newContact.Name = contactName;
                newContact.Phone = contactPhone;
                context.Contacts.Add(newContact);
                context.SaveChanges();
            }
        }

        public List<Contact> LoadContactsFromDb()
        {
            using (var context = new ContactsDbContext())
            {
                var contacts = context.Contacts.ToList();
                return contacts;
            }
        }
    }
}
