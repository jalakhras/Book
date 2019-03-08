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
            : base("BookConnection")
        {
        }

        public static IdentityDb Create()
        {
            return new IdentityDb();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("identity");
            base.OnModelCreating(modelBuilder);
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