using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAutomatisé.DomaineClasses
{
    public class Photo
    {
        public virtual int PhotoId { get; set; }
        public  virtual String UrlPhoto { get; set; }
        public  virtual int PersonneId { get; set; }//clé etrangères;
        public virtual Personne personnes { get; set; }//type Navigation, car c'est bi'Directionnel; 

        //entity framework
    }
}