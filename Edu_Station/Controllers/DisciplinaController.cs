using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edu_Station.Controllers
{
    public class DisciplinaController : Controller
    {
        // GET: Disciplina
        public ActionResult IndexDisciplina()
        {
            return View();
        }

        // GET: Disciplina/Create
        public ActionResult CriarDisciplina()
        {
            return View();
        }

        
    }
}