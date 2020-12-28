using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernateMySQL.Models
{
    public class NHibertnateSession
    {
        public static ISession OpenSession()
        {
            var mConfiguration = new Configuration();
            var path = HttpContext.Current.Server.MapPath(@"~\NHibernate\NHibernate.cfg.xml");
            mConfiguration.Configure(path);
            var model = HttpContext.Current.Server.MapPath(@"~\Models\Product.hbm.xml");
            mConfiguration.AddFile(model);
            ISessionFactory mSession = mConfiguration.BuildSessionFactory();
            return mSession.OpenSession();
        }
    }
}