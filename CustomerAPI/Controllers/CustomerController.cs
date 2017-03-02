using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            return Json(DataBase.GetAllCustomer());
        }
    }
}
