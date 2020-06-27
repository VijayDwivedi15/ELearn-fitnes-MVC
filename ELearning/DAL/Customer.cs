using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ELearning.Models;

namespace ELearning.DAL
{
    public class Customer
    {
        public Models.UserDetailModal GetUserDetailByEmail(string EmailID)
        {

            var status = new Models.UserDetailModal();

            using (var db = new UserContext())
            {
                var uname = new SqlParameter("@EmailID", EmailID);

                status = db.Database
                          .SqlQuery<Models.UserDetailModal>("exec USP_GetUserDetailByEmail @EmailID", uname).FirstOrDefault();
            }

            return status;
        }
    }
}