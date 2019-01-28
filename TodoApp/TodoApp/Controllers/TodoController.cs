using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {

        public ActionResult Index()
        {
            // bevásárló lista adatai Só,Cukor,Spagetti,Marhahús,Paradicsom
           




            //a Viewbag -be tett adatokat a nézeteb ki tudjuk olvasni
            //Figyelem az erősen tipusos védelmet itt elveszítjük.
            //ViewBag.Lista = lista;


            return View(MyDb.Lista);

        }
        public ActionResult Create(string Name)
        {
            if (!string.IsNullOrEmpty(Name))
            {
                MyDb.Lista.Add(new TodoItem() { Name = Name, Done = true });

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}