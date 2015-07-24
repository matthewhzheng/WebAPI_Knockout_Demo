using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTestApplication.Models
{

    public class UserProfileDB
    {
        private static UserProfileDB instance = null;
        public List<UserProfile> UserProfiles { get; set; }

        private UserProfileDB()
        {
            UserProfiles = new List<UserProfile>
                               {
                                   new UserProfile("Matt", 5),
                                   new UserProfile("Elwin", 4),
                                   new UserProfile("Veronica", 3),
                                   new UserProfile("Mike", 2)
                               };
        }

        public static UserProfileDB GetInstance()
        {
            if (instance == null)
            {
                instance = new UserProfileDB();
            }
            return instance;
        }



    }
}