using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernateMySQL.Models
{
    public class Products
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Brand { get; set; }
        public virtual string CreateAt { get; set; }
    }
}