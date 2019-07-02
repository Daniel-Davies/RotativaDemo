using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RotativaDemo.Models;
using Rotativa.AspNetCore;

namespace RotativaDemo.Controllers
{
    [Controller]
    public class HomeController : Controller
    {

        public IActionResult LeagueTable()
        {
            LeagueTable premierLeague = new LeagueTable();
            premierLeague.createTableInstance();

            return View(premierLeague);
        }

        public IActionResult LeaguePDF()
        {
            LeagueTable premierLeague = new LeagueTable();
            premierLeague.createTableInstance();

            ViewData["Name"] = "Daniel Davies";

            return new ViewAsPdf("LeagueTable", premierLeague) {
                CustomSwitches = "--footer-center [page]"
            };
        }

    }
}