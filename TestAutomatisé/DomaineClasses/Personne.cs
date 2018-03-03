using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAutomatisé.DomaineClasses
{
    public class Personne
    {
        public virtual int PersonneId { get; set; }
        public virtual string Trigramme
        {
            get; set;
        }
        
        public virtual string NomPersonne { get; set; }
        public virtual string Mdp { get; set; }
       // public virtual string ImagePersonne { get; set; }
        public virtual string ContactPersonne { get; set; }
        public virtual string AdressePersonne { get; set; }
        public virtual string EmailPersonne { get; set; }
        public virtual string UrlPhoto { get; set; }

        //public virtual ICollection<Photo> Photos { get; set; }


    }
}