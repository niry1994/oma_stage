using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using TestAutomatisé.DomaineClasses;

namespace TestAutomatisé.MappingClasses
{
    public class UtilisateurMapping :ClassMap<Utilisateur>
    {
        public UtilisateurMapping()
        {
            Id(m=>m.IdUtilisateur);
            Map(m=>m.NomUtilisateur);
            Table("Utilisateur");
        }
    }
}