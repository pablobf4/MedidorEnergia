using IdentitySample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class GoogleChartController : Controller
    {
        // GET: GoogleChart
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult GetChartData(string Id)
        {
            using (var db = new ApplicationDbContext()) 
            {
             var result = (from medidas in db.Medidas
                             
                             select new { medidas.Potencia , medidas.Horario}).ToList();
                             return Json(result, JsonRequestBehavior.AllowGet);
             
            
            }
          
          
            
        }

        //public JsonResult GetChartDataDia(string Id)
        //{
        //    using (var db = new ApplicationDbContext())
        //    {
        //        var lista = db.Medidas.GroupBy(x => new
        //        {
        //            dia = x.Horario.Day,
                  
        //        }).Select(s => new
        //        {
        //            DataAritmetica = s.Average(m => m.Potencia),
        //            s.Key.dia,
                    
        //        }).ToList();

        //        return Json(lista, JsonRequestBehavior.AllowGet);


        //    }



        //}

        
    }
}