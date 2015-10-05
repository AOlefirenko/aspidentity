using AspNet.Identity.MongoDB;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Accounts.DAL
{
    public class UserManager : UserManager<IdentityUser>
    {
        public IUserStore<IdentityUser> Users { get; private set; }
        public UserManager(IUserStore<IdentityUser> store)
            : base(store)
        {
            Users = store;
            UserValidator = new UserValidator<IdentityUser>(this)
            {
                AllowOnlyAlphanumericUserNames = false
            };

            PasswordValidator = new MinimumLengthValidator(6);
        }
    }
}