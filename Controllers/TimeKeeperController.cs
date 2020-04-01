using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class TimeKeeperController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            TimeKeeperModel timeKeeperModel = new TimeKeeperModel {
                MondayStart = 0.00M
            };
            return View("Index", timeKeeperModel);
        }

        [HttpPost]
        public IActionResult Index(TimeKeeperModel tkm)
        {
            TimeKeeperModel timeKeeperModel = new TimeKeeperModel {
                MondayStart = tkm.MondayStart
            };

            return View("Index", timeKeeperModel);
        }

    }
}