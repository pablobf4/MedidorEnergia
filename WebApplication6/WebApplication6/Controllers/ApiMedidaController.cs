using IdentitySample.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication6.Models;
using Microsoft.AspNet.Identity;
using System.Web;
using Microsoft.Owin.Security;
//api que recebe os valores do arduino e envia para banco de dados
namespace WebApplication6.Controllers
{
    [RoutePrefix("api/medida")]
    

    public class ApiMedidaController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

               

        [Authorize]
        [HttpGet]
        [Route("{irms}/{potencia}")]
        public HttpResponseMessage GetMedidasServidor (float irms, float potencia)
        {
                          
           
            Medida medida = new Medida( irms,potencia);
            
            try {
 
            if(ModelState.IsValid)
            {
                db.Medidas.Add(medida);
                db.SaveChanges();
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, medida);
               // response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = medida.IDMedida }));
                return response;

            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

                }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }
    }
}


