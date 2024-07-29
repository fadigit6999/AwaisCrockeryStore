using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharApp.WinHelper
{
    public class UserService
    {
        private readonly BAL.User _getRoles;

        public UserService(BAL.User getRoles)
        {
            _getRoles = getRoles;
        }

        public async Task<BML.AspNetUser> GetUserRole(string Username) 
        { 
            var user = new BML.AspNetUser();
            var userSession = await _getRoles.ReadUserAsync();
            user = userSession.Where(x => x.UserName == Username).SingleOrDefault();
            if (user is not null)
                return user;
            
            return null;
        }


    }
}
