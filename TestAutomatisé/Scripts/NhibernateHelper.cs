using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Configuration.Assemblies;
using System.Reflection;
using NHibernate;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using TestAutomatisé.DomaineClasses;



namespace TestAutomatisé.Models.DomaineClasses
{
    public static class NhibernateHelper
    {
       
        internal static IDisposable Create()
        {
            throw new NotImplementedException();
        }

        private static ISessionFactory _sessionFactory;


        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = InitializeSession();
                }
                return _sessionFactory;
            }
        }
        public static ISessionFactory InitializeSession()
        {
            var connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=utilisateurs;SslMode=none";
            var cfg = MySQLConfiguration.Standard.ConnectionString(connectionString);        
           var configuration = Fluently.Configure().Database(cfg).Mappings(m => m.FluentMappings.AddFromAssemblyOf<PersonneMap>()).BuildConfiguration();
            return configuration.BuildSessionFactory();
        }

       
        public static ISession OuvertureSession()
        {
            return SessionFactory.OpenSession();
        }
        
    }
}