using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edu_Station.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Entrar()
        {
            return View();
        }

      
        
    }
}