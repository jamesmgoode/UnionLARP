using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UnionLARP.Controllers
{
    public class TorchbearerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
