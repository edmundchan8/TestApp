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
                MondayStartHour = 0,
                MondayStartMinute = 00
            };
            return View("Index", timeKeeperModel);
        }

        [HttpPost]
        public IActionResult Index(TimeKeeperModel tkm)
        {
            if (ModelState.IsValid)
            {
                TimeKeeperModel timeKeeperModel = new TimeKeeperModel
                {
                    MondayStartHour = tkm.MondayStartHour,
                    MondayStartMinute = tkm.MondayStartMinute,

                };
                return View("Index", timeKeeperModel);
            }
            else
                return View(tkm);
        }

    }
}