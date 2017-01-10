using IdentitySample.Models;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class MeController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // Retorna Nosso Authentication Manager
        private IAuthenticationManager Authentication
        {
            get { return HttpContext.Current.GetOwinContext().Authentication; }
        }

        // GET api/me
        // A tag Authorize obriga estar autenticado para acessar o mesmo
        [Authorize]
        public string Get()
        {
            Medida medida = new  Medida(Authentication.User.Identity.Name);

            try
            {

                if (ModelState.IsValid)
                {
                    db.Medidas.Add(medida);
                    db.SaveChanges();
                    //HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, medida);
                    //// response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = medida.IDMedida }));
                    //return response;

                }
                else
                {
                  //  return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Authentication.User.Identity.Name;
        }
        }
}