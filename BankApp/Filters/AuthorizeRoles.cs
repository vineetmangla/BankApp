using BankApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApp.Filters
{
    public class AuthorizeRoles : AuthorizeAttribute
    {
        private UserType[] Roles;

        public AuthorizeRoles(params UserType[] roles)
        {
            Roles = roles;
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            foreach(var role in Roles)
            {
                if(httpContext.User.IsInRole(role.ToString()))
                {
                    return true;
                }
            }
            return false;
                
        }
    }
}