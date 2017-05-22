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
    public class TechnologiesController : ApiController
    {
        public HttpResponseMessage GetTechnologies()
        {
            try
            {
                using (NgLearnEntities entities = new NgLearnEntities())
                {
                    var technology = entities.Technologies.Include("Subjects").ToList();
                    List<Technologies> technologies = new List<Technologies>();
                    foreach (Technology tech in technology)
                    {
                        List<Subjects> subs = new List<Subjects>();
                        foreach (Subject sub in tech.Subjects)
                        {
                            subs.Add(new Subjects() { id = sub.id, subject = sub.subject1, techid = sub.techid });
                        }
                        technologies.Add(new Technologies() { id = tech.id, domain = tech.domain, subjects = subs });
                    }

                    return Request.CreateResponse(HttpStatusCode.OK, technologies);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}
