using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ComponyAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        // GET: Department
        CompanyDBEntities db = new CompanyDBEntities();
        public IHttpActionResult getAll(Department dp)
        {
            var dep = db.Departments.Select(a => new
            {
                a.ID,
                a.Names

            });
            return Ok(dep);
        }

        public IHttpActionResult Add(Department dp)
        {
            db.Departments.Add(dp);
            db.SaveChanges();           
            return Ok(dp);
        }

        public IHttpActionResult delete(int id)
        {
        }
         
    }
}