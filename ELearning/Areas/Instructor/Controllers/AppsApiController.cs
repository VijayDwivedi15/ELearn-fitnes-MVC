using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ELearning.DAL;
using ELearning.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web;
using System.IO;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Text;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Configuration;


namespace ELearning.Areas.Instructor.Controllers
{
    [RoutePrefix("api/apps")]
    public class AppsApiController : ApiController
    {
        AdminManager admin = new AdminManager();

        public AppsApiController()
            : this(new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())))
        {
        }

        public AppsApiController(UserManager<ApplicationUser> userManager)
        {
            UserManager = userManager;
        }

        public UserManager<ApplicationUser> UserManager { get; private set; }
        UserContext db = new UserContext();

        [Route("GetSubjectList")]
        [AllowAnonymous]
        public List<CourseCategory> GetSubjectList()
        {
            var cdetail = db.CourseCategory.ToList();
            return cdetail;
        }

    }
}