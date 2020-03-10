using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edu_Station.Controllers
{
    public class TurmaController : Controller
    {
        // GET: Turma
        public ActionResult IndexTurma()
        {
            return View();
        }
        // GET: Turma/Create
        public ActionResult CriarTurma()
        {
            return View();
        }

       
    }
}