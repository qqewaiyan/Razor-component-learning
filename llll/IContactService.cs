using llll.Models;

namespace llll
{
    public interface IContactService
    {
        List<Contact> GetContacts();

        void AddContact(Contact contact);
    }
}
