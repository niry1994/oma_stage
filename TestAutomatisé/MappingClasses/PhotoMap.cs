using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestAutomatisé.DomaineClasses;
using FluentNHibernate.Mapping;

namespace TestAutomatisé.DomaineClasses
{
    public class PhotoMap : ClassMap<Photo>
    {
        public PhotoMap()
        {
            Id(c => c.PhotoId);
            Map(c => c.UrlPhoto);
            //Map(c => c.PersonneId);
            References(c => c.personnes).Column("PersonneId");
            Table("Photo");
        }

    }
}
