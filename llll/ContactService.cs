using llll.Models;

namespace llll
{
    public class ContactService : IContactService
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public List<Contact> GetContacts()
        {
            return contacts;
        }
    }
}
