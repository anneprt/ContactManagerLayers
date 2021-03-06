﻿using ContactsManager.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.Business
{
    public interface IServiceContact
    {
        IEnumerable<Contact> ChercherContacts(string texte);

        void CreerContact(Contact contact);

        IEnumerable<Contact> GetContacts();

        void SupprimerContact(Contact contact);
    }
}
