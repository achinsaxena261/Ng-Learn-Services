﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NgLearnService.Models;
using TechnologiesDataAccess;

namespace NgLearnService.Controllers
{
    public class UserController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            try
            {
                using (NgLearnEntities entities = new NgLearnEntities())
                {
                    var users = entities.Users.ToList();
                    List<Users> usrList = new List<Users>();
                    foreach (User user in users)
                    {
                        usrList.Add(new Users() {email=user.email,gender=user.gender, name=user.uname });
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, usrList);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        public HttpResponseMessage ValidateUser([FromUri]string email,string pwd)
        {
            try
            {
                using (NgLearnEntities entities = new NgLearnEntities())
                {
                    var user = entities.Users.ToList().Where(o => o.email == email && o.pwd == pwd).FirstOrDefault();
                    return Request.CreateResponse(HttpStatusCode.OK, new Users() { email = user.email, gender = user.gender, name = user.uname,img=user.imgpath == null? string.Empty : user.imgpath });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }



    }
}
