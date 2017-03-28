using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Services
{
    public class ContactRepository
    {
        public Contact[] GetAllContacts()
        {
            return new Contact[]
            {
                new Contact()
                {
                    Id = 1,
                    Name = "Contact1"

                },
                new Contact()
                {
                    Id = 2,
                    Name = "Contact2"

                },
                new Contact()
                {
                    Id = 3,
                    Name = "Contact3"

                }
            };
        }
    }
}