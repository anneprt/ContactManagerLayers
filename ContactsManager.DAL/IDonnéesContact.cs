using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.DAL
{
    public interface IDonneesContact
    {
        IEnumerable<Contact> GetListe();

        void Enregistrer(Contact contact);

        void Supprimer(Contact contact);
    }
}
