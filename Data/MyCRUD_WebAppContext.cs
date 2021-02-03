using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyCRUD_WebApp.Data
{
    public class MyCRUD_WebAppContext : DbContext
    {
        public MyCRUD_WebAppContext() : base("name=MyCRUD_WebAppContext")
        {
        }
        public System.Data.Entity.DbSet<MyCRUD_WebApp.Models.Contact> Contacts { get; set; }
    }
}

