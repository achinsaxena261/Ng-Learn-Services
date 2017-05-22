using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechnologiesDataAccess;
using NgLearnService.Models;

namespace NgLearnService.Controllers
{
    public class TutorialsController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            try
            {
                using (NgLearnEntities entities = new NgLearnEntities())
                {
                    var tutorial = entities.Tutorials.ToList();
                    List<Tutorials> tutorials = new List<Tutorials>();
                    foreach (Tutorial tute in tutorial)
                    {
                        tutorials.Add(new Tutorials() { id = tute.id, url = tute.url, subid = tute.subid });
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, tutorials);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage GetTutorials(int id)
        {
            try
            {
                using (NgLearnEntities entities = new NgLearnEntities())
                {
                    var tutorial = entities.Tutorials.Where(o => o.subid == id).ToList();
                    List<Tutorials> tutorials = new List<Tutorials>();
                    foreach (Tutorial tute in tutorial)
                    {
                        tutorials.Add(new Tutorials() { id = tute.id, url = tute.url, subid = tute.subid });
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, tutorials);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}
