using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using MVCTestApplication.Models;

namespace MVCTestApplication.Controllers
{
    public class UserProfileController : ApiController
    {
        // GET api/getuserprofile
        public IEnumerable<UserProfile> Get()
        {
            return UserProfileDB.GetInstance().UserProfiles;
        }

        // POST api/getuserprofile
        //public void Post([FromBody]UserProfile profile)
        public IEnumerable<UserProfile> Post(UserProfile profile)
        {
            //Security testing
            //var principal = Thread.CurrentPrincipal;

            //end security testing

            UserProfileDB.GetInstance().UserProfiles.Add(profile);
            return UserProfileDB.GetInstance().UserProfiles;
        }

        // PUT api/getuserprofile/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/getuserprofile/5
        public void Delete(int id)
        {
        }
    }
}
