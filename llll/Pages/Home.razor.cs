using llll.Models;

namespace llll.Pages
{
    public partial class Home
    {
        private List<Contact> contacts;

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(5000);
            contacts = new List<Contact>
        {
            new Contact
            {
                FirstName = "Wai Yan",
                LastName = "Phyo Mg",
                Email = "waiyan@gmail.com"
            },
            new Contact
            {
                FirstName = "Ma Ma",
                LastName = "Phyo Mg",
                Email = "Ma Ma@gmail.com"

            },
            new Contact
            {
                FirstName = "Skippp",
                LastName = "Phyo Mg",
                Email = "skippVile@gmail.com"
            },
        };
            base.OnInitializedAsync();
        }
    }
}
