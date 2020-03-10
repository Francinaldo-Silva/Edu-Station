using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edu_Station.Controllers
{
    public class DocenteController : Controller
    {
        // GET: Docente
        public ActionResult IndexDocente()
        {
            return View();
        }

        
        // GET: Docente/Create
        public ActionResult CriarDocente()
        {
            return View();
        }

       
    }
}