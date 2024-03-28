using llll.Models;

using Microsoft.AspNetCore.Components;
namespace llll.Pages
{

    
    public partial class Home
    {
        [Inject]
        IContactService contactService { get; set; }
        private List<Contact> contacts;

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(5000);
            
            contacts = contactService.GetContacts();
        //    contacts = new List<Contact>
        //{
        //    new Contact
        //    {
        //        FirstName = "Wai Yan",
        //        LastName = "Phyo Mg",
        //        Email = "waiyan@gmail.com"
        //    },
        //    new Contact
        //    {
        //        FirstName = "Ma Ma",
        //        LastName = "Phyo Mg",
        //        Email = "Ma Ma@gmail.com"

        //    },
        //    new Contact
        //    {
        //        FirstName = "Skippp",
        //        LastName = "Phyo Mg",
        //        Email = "skippVile@gmail.com"
        //    },
        //};
            base.OnInitializedAsync();
        }
    }
}
