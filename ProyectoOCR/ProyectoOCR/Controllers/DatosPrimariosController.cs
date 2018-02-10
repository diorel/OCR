using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoOCR.Controllers
{
    public class DatosPrimariosController : Controller
    {
        // GET: DatosPrimarios
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(string FirtsName1)
        {
            var cariable1 = FirtsName1;


            if (cariable1 != null)
                return Json("'Success':'true'");
            else
                return Json(String.Format("'Success':'false','Error':'Ha habido un error al insertar el registro.'"));


        }







        //[HttpPost]
        //public ActionResult Create(string FirtsName1,string FirtsName2,string SecondName1,string SecondName2,string Curp,string Date,string Street,string OutdoorNumber, string InteriorNumber,string PostalCode,string Colony,string Delegacion,string Entidad,string Celular,string Email,string Telefon,string Entry)
        //{
        //    var cariable1 = FirtsName1;
        //    var cariable2 = FirtsName2;
        //    var cariable3 = SecondName1;
        //    var cariable4 = SecondName2;
        //    var cariable5 = Curp;
        //    var cariable6 = Date;
        //    var cariable7 = Street;
        //    var cariable8 = OutdoorNumber;
        //    var cariable9 = InteriorNumber;
        //    var cariable17 = PostalCode;
        //    var cariable10 = Colony;
        //    var cariable11 = Delegacion;
        //    var cariable12 = Entidad;
        //    var cariable13 = Celular;
        //    var cariable14 = Email;
        //    var cariable15 = Telefon;
        //    var cariable16 = Entry;
            
        //    return RedirectToAction("AdjuntarDocumento");
        //}




        public ActionResult AdjuntarDocumento()
        {
            return View();
        }


    }
}