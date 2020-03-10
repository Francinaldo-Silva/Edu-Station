using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edu_Station.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult IndexAluno()
        {
            return View();
        }
        // GET: Aluno/Create
        public ActionResult CriarAluno()
        {
            return View();
        }



        
    }
}