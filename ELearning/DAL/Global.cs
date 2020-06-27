using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace ELearning.DAL
{
    public class Global
    {
        AdminManager admin = new AdminManager();
        UserContext db = new UserContext();
        public static string result = String.Empty;
        public static string WebsiteUrl()
        {

            switch (ConfigurationManager.AppSettings["Environment"].ToString().ToLower())
            {

                case "local":
                    result = "http://localhost:1545/";
                    break;
                case "development":
                    result = "http://hygienindia.com/";
                    break;
                //case "production":
                //    result = "http://www.hihuzurweb.com/";
                //    break;
                default:
                    result = "http://www.hihuzurweb.com/";
                    break;
            }

            return result;
        }
        public class Page
        {
            public int PageSize { get; set; }
        }
        public List<Page> GetPaging()
        {
            List<Page> PageList = new List<Page>();
            PageList.Add(new Page { PageSize = 1 });
            PageList.Add(new Page { PageSize = 5 });
            PageList.Add(new Page { PageSize = 10 });
            PageList.Add(new Page { PageSize = 20 });
            PageList.Add(new Page { PageSize = 50 });
            PageList.Add(new Page { PageSize = 100 });

            return PageList;
        }
    }
}