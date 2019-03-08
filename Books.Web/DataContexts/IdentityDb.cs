using Books.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Books.Web.DataContexts
{
    public class IdentityDb : IdentityDbContext<ApplicationUser>
    {
        public IdentityDb()
            : base("DefaultConnection")
        {
        }

        public static IdentityDb Create()
        {
            return new IdentityDb();
        }

    }
}


//public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
//{
//    public ApplicationDbContext()
//        : base("DefaultConnection", throwIfV1Schema: false)
//    {
//    }

//    public static ApplicationDbContext Create()
//    {
//        return new ApplicationDbContext();
//    }
//}