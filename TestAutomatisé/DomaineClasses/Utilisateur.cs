using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestAutomatisé.DomaineClasses
{
    public class Utilisateur
    {
        [Key]
        public virtual int IdUtilisateur{ get; set; }
        public virtual String NomUtilisateur { get; set; }
    }
}