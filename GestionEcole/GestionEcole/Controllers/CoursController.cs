using GestionEcole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEcole.Controllers
{
    
    public class CoursController : Controller
    {
        private int nbElement = 7;
        private EcoleContainer DB = new EcoleContainer();

        #region Default CRUD

        [Authorize(Roles = "Admin")]
        public ActionResult Index(int numPage = 0)
        {
            List<Cours> cours = (from c in DB.Cours
                                 select c).ToList();

            List<Cours> lstPage = (from c in DB.Cours
                                 select c).OrderBy(o => o.CoursId).Skip(nbElement * numPage).Take(nbElement).ToList();

            ViewBag.combienDePage = cours.Count() / nbElement;

            return View(lstPage);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Details(int id)
        {
            Cours cours = (from c in DB.Cours
                           where c.CoursId == id
                           select c).First();

            return View(cours);
        }

        #region Create Region

        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.Matieres = (from m in DB.Matieres
                                select m).ToList().Select(c => new SelectListItem { Value = c.MatiereId.ToString(), Text = c.Titre });

            var teachers = (from e in DB.Enseignants
                            select e).ToList().Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Prenom + " " + c.Nom });

            ViewBag.Teachers = teachers;

            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(Cours NouvCours)
        {
            try
            {
                
                if (ModelState.IsValid)
                {
                    if (NouvCours.DateDebut.CompareTo(NouvCours.DateFin) < 0)
                    {
                        DB.Cours.Add(NouvCours);

                        DB.SaveChanges();

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.Matieres = (from m in DB.Matieres
                                            select m).ToList().Select(c => new SelectListItem { Value = c.MatiereId.ToString(), Text = c.Titre });

                        var teachers = (from e in DB.Enseignants
                                        select e).ToList().Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Prenom + " " + c.Nom });

                        ViewBag.Teachers = teachers;

                        ModelState.AddModelError("", GestionEcole.Resources.Views.Cours.Index.ErrorDate);
                        return View(NouvCours);

                    }
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        #endregion

        #region Edit Region

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            Cours cours = (from c in DB.Cours
                           where c.CoursId == id
                           select c).First();

            return View(cours);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Edit(int id, Cours EditCours)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Cours cours = (from c in DB.Cours
                                   where c.CoursId == id
                                   select c).First();

                    cours.DateDebut = EditCours.DateDebut;
                    cours.DateFin = EditCours.DateFin;
                    cours.Description = EditCours.Description;

                    DB.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        #endregion

        #region Delete Region

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            Cours cours = (from c in DB.Cours
                           where c.CoursId == id
                           select c).First();

            return View(cours);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Cours cours = (from c in DB.Cours
                               where c.CoursId == id
                               select c).First();

                DB.Cours.Remove(cours);

                DB.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        #endregion

        #endregion

        #region Affichage des etudiants d'un cours

        [Authorize(Roles = "Admin, Enseignant")]
        public ActionResult AfficheEtudiantsCours(int coursId)
        {
            var etudiants = (from c in DB.PresenceCours
                             where c.CoursId == coursId
                             select c.Etudiant).ToList();

            ViewBag.leCours = (from c in DB.Cours
                               where c.CoursId == coursId
                               select c).First();

            return View(etudiants);
        }

        #endregion

        protected override void Dispose(bool disposing)
        {
            DB.Dispose();
            base.Dispose(disposing);
        }
    }
}
