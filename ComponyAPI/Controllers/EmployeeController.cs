using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace ComponyAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET: Employee
        CompanyDBEntities db = new CompanyDBEntities();
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var data = db.Employees.Select(a => new
            {
                a.ID,
                a.FullName,
                a.Email,
                Department = a.DepartmentId


            }).ToList();


            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult Add(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
            return Ok(emp);
        }

        [System.Web.Http.HttpDelete]
        public IHttpActionResult delete(int id)
        {
            var emp = db.Employees.Find(id);

            if (emp == null)
                return NotFound();

            db.Employees.Remove(emp);
            db.SaveChanges();

            return Ok("Employee deleted successfully");

        }
    }
}