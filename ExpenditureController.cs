using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QueteRazor.Models;

namespace QueteRazor.Controllers
{
    public class ExpenditureController : Controller
    {
        // GET: Expenditure
        public ActionResult CreateList()
        {
            List<Expenditure> listeDepense = new List<Expenditure>();
            listeDepense.Add(new Expenditure ("St Jacques", new DateTime(2021,2,8), 15)) ;
            listeDepense.Add(new Expenditure("Munster", new DateTime(2021, 2, 8), 3.5));
            listeDepense.Add(new Expenditure("Avocat", new DateTime(2021, 2, 8), 1.5));
            ViewData["somme"] = listeDepense.Select(e => e.Price).Sum(); 
            return View("CreateList", listeDepense);
        }
    }
}