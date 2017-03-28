using WebApi.Models;
using System.Web.Http;
using WebApi.Services;

namespace WebApi.Controllers
{
    public class ContactController : ApiController
    {
        private readonly ContactRepository _contactRepository;

        public ContactController()
        {
            this._contactRepository = new ContactRepository();
        }

        public Contact[] Get()
        {
            return _contactRepository.GetAllContacts();
        }
    }
}
