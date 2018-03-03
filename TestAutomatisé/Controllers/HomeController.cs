using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAutomatisé.DomaineClasses;
using TestAutomatisé.Models.DomaineClasses;

using NHibernate;
using System.Data;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace TestAutomatisé.Controllers
{
    public class HomeController : Controller
    {
        //int TempId;
       
        [HttpPost]
        public ActionResult Login(Personne model)
        {
           
            using (var session = NhibernateHelper.OuvertureSession())
            {
                try
                {
                
                    var query = (from uti in session.Query<Personne>()
                                 where uti.Mdp == model.Mdp && uti.Trigramme == model.Trigramme
                                 select new
                                 {
                                     PersonneId = uti.PersonneId,
                                     NomPersonne = uti.NomPersonne,
                                     mdp = uti.Mdp,
                                     Trigramme = uti.Trigramme,
                                     ContactPersonne = uti.ContactPersonne,
                                     AdressePersonne = uti.AdressePersonne,
                                     Email = uti.EmailPersonne
                                 }
                                 ).Single(); 
                    return RedirectToAction("Welcome", "Home", new { id=query.PersonneId});
                   
                }
                catch (Exception exe)
                {
                   
                    return View();
                }
            }
        }
        [HttpGet]
        public ActionResult Login(int id = 0)
        {
            return View();
        }

        public ActionResult Start()
        {
            return View();
        }
        public ActionResult Deconnexion()
        {
            Session.Clear();
            return RedirectToAction("Start","Home");
        }
        public ActionResult InfoPersonne(int id)
        {

            using (ISession session = NhibernateHelper.OuvertureSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var personne = session.Get<Personne>(id);
                   

                    return View(personne);
                    
                }
            }

        }
        [HttpGet]

        public ActionResult Registre(int id=0)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registre(Personne utilisateur,Photo photo, HttpPostedFileBase file)
        {
            try
            {

                using (ISession session = NhibernateHelper.OuvertureSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(utilisateur);
                        transaction.Commit();
                        return RedirectToAction("Login", "Home");
                    }
                }
               
            }
            catch(Exception e)
            {
                return View("Start");
            }
           
        }
        [HttpPost]
        public ActionResult RegistreS(Photo photos,HttpPostedFileBase file)
        {
            try
            {
                using (ISession session = NhibernateHelper.OuvertureSession())
                {

                    if (file.ContentLength > 0)
                    {
                        String filename = Path.GetFileName(file.FileName);
                        String path = Path.Combine(Server.MapPath("~/UploadFiles"), filename);
                        file.SaveAs(path);

                        photos.UrlPhoto = "~/UploadFiles/" + filename;

                    }
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        photos.PersonneId = 2;
                        session.Save(photos);
                        transaction.Commit();
                        return RedirectToAction("Login", "Home");
                    }
                }
            }
            
             catch (Exception e)
            {
                return View("Start");
            }
        }
        public ActionResult Welcome(int id)
        {
            using (ISession session = NhibernateHelper.OuvertureSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var personne = session.Get<Personne>(id);
                    return View(personne);
                }
            }
        }

        IEnumerable<Personne> GetPersonne()
        {
            using (ISession session = NhibernateHelper.OuvertureSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var utilsateur = session.Query<Personne>().ToList();
                    return utilsateur;
                }
            }
        }
        
        public ActionResult VoirAllUser()
        {
            using (ISession session = NhibernateHelper.OuvertureSession())
            {
                var utilsateur = session.Query<Personne>().ToList();
                return View(utilsateur);
            }          
        }

        public ActionResult ViewResult()
        {
            using (ISession session = NhibernateHelper.OuvertureSession())
            {
                var utilisateur = session.Query<Utilisateur>().ToList();
                return View(utilisateur);
            }
        }
        [HttpGet]
        public ActionResult AddUtilisateur()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUtilisateur(Utilisateur utilisateur)
        {
            using (ISession session = NhibernateHelper.OuvertureSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(utilisateur);
                }
                return View();
            }
                
        }
    }
   
}