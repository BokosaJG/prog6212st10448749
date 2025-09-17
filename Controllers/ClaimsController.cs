using Microsoft.AspNetCore.Mvc;
using CMCS_MVC.Models;
using System;
using System.Collections.Generic;

namespace CMCS_MVC.Controllers
{
    public class ClaimsController : Controller
    {
        public IActionResult Index()
        {
            var claims = new List<Claim>
            {
                new Claim { LecturerName = "Alice Smith", HoursWorked = 10, HourlyRate = 450, Status = "Verified" },
                new Claim { LecturerName = "Bob Jones", HoursWorked = 5, HourlyRate = 400, Status = "Submitted" }
            };
            return View(claims);
        }

        public IActionResult Create()
        {
            return View(new Claim());
        }

        public IActionResult Details(Guid id)
        {
            var claim = new Claim
            {
                LecturerName = "John Doe",
                HoursWorked = 8,
                HourlyRate = 500,
                Status = "Submitted",
                Notes = "Prototype only"
            };
            return View(claim);
        }
    }
}