using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _200382884F.Models
{
    public class _200382884FContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public _200382884FContext() : base("name=_200382884FContext")
        {
        }

        public System.Data.Entity.DbSet<_200382884F.Models.ChatMessage> ChatMessages { get; set; }
    }
}
