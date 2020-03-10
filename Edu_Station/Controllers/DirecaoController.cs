using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edu_Station.Controllers
{
    public class DirecaoController : Controller
    {
        // GET: Direcao
        public ActionResult IndexDirecao()
        {
            return View();
        }

        // GET: Direcao/Create
        public ActionResult CriarDirecao()
        {
            return View();
        }

        
    }
}