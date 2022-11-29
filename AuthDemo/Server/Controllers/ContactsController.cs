using AuthDemo.Server.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactsRepo _repo;
        public ContactsController(IContactsRepo repo)
        {
            _repo = repo;
        }
    }
}
