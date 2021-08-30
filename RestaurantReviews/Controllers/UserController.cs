﻿using Microsoft.AspNetCore.Mvc;
using RestaurantReviews.Data;
using RestaurantReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Controllers
{
    public class UserController : Controller
    {
        // variable to identify is user is logged in.
        bool loggedIn = false;
        string username = "none";

        private IRepository _appRepo;

        public UserController(IRepository appRepo)
        {
            _appRepo = appRepo;
        }

        public bool isLoggedIn()
        {
            return loggedIn;
        }

        public string getUsername()
        {
            return username;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            if (!loggedIn)
            {
                return View();
            } else
            {

            }
            return View("Index");
        }

        [HttpPost]
        public IActionResult SignIn(string username, string password)
        {
            if(_appRepo.LogIn(username, password).Equals("Not a valid login.")){
                return View("Error");
            } else
            {
                ViewBag.Username = username;
                TempData["user"] = username;
                this.username = username;
                loggedIn = true;
                return View("LoggedIn");
            }
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string name, string username, string password)
        {
            ViewData["name"] = _appRepo.RegisterAccount(name, username, password);
            return View();
        }
    }
}
