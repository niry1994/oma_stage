using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestAutomatisé.DomaineClasses;
using FluentNHibernate.Mapping;

namespace TestAutomatisé.DomaineClasses
{
    public class PersonneMap : ClassMap<Personne>
    {
        public PersonneMap()
        {
            Id(c => c.PersonneId);
            Map(c => c.Trigramme);
            Map(c => c.NomPersonne);
            Map(c => c.Mdp);
            Map(c => c.ContactPersonne);
            Map(c => c.AdressePersonne);
            Map(c => c.EmailPersonne);
            Map(c => c.UrlPhoto);
            Table("Personne");
        }

    } 
}
