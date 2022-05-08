using AutoMapper;
using BP.Api.Data.Models;
using BP.Api.Models;
using System;

namespace BP.Api.Service
{
    public class ContactService : IContactService
    {
        private readonly IMapper mapper;

        public ContactService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public ContactDVO GetContactById(int Id)
        {
            Contact dbContact = getDummyContact();

            //IHttpClientFactory


            //Auto Mapper
            //ContactDVO contactDVO = new ContactDVO();
            //mapper.Map(dbContact, contactDVO);

            ContactDVO resultContact = mapper.Map<ContactDVO>(dbContact);
            return resultContact;

            /*
            return new ContactDVO()
            {
                Id = dbContact.Id,
                FullName = $"{dbContact.FirstName} {dbContact.LastName}"
            };
            */
        }

        private Contact getDummyContact()
        {
            return new Contact()
            {
                Id = 1,
                FirstName = "Can",
                LastName = "Canbolat"
            };
        }
    }
}
