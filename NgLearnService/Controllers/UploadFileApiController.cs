using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

namespace NgLearnService.Controllers
{
    public class UploadFileApiController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage UploadJsonFile()
        {
            try
            {
                var httpRequest = HttpContext.Current.Request;
                string filePath = "";
                if (httpRequest.Files.Count > 0)
                {
                    foreach (string file in httpRequest.Files)
                    {
                        var postedFile = httpRequest.Files[file];
                        filePath = HttpContext.Current.Server.MapPath("~/UploadFile/" + postedFile.FileName);
                        postedFile.SaveAs(filePath);
                    }
                }
                return Request.CreateResponse(HttpStatusCode.OK, filePath);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        } 
    }
}
