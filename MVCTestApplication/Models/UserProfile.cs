using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTestApplication.Models
{
    public class UserProfile
    {
        public string UserName { get; set; }
        public int FavoriteNumber { get; set; }

        public UserProfile(string userName, int favoriteNumber)
        {
            UserName = userName;
            FavoriteNumber = favoriteNumber;
        }
    }
}