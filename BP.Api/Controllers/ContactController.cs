using BP.Api.Models;
using BP.Api.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly IContactService contactService;

        public ContactController(IConfiguration configuration, IContactService contactService)
        {
            this.configuration = configuration;
            this.contactService = contactService;
        }

        [HttpGet]
        public string Get()
        {
            return configuration["ReadMe"].ToString();
        }

        [HttpGet("{id}")]
        [ResponseCache(Duration = 10)]
        public ContactDVO GetContactById(int id)
        {
            return contactService.GetContactById(id);
        }

        [HttpPost]
        public ContactDVO Create(ContactDVO contact)
        {
            //normalde db'ye kayıtlar vs yapılır.
            return contact;
        }
    }
}
