using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Regesteration_LoginPages_API.Models;

namespace Regesteration_LoginPages_API.Controllers
{
    public class EmployeeController : ApiController
    {

        [Authorize]
        public IEnumerable<Employees> Get()
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                return _context.Employees.ToList();
            }
        }
    }
}
