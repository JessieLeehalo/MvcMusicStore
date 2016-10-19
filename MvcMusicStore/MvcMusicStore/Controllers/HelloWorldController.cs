﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}

        public ActionResult Index()
        {
            return View();
        }

        public string Welcome(string name, int id)
        {
            // http://localhost:xxxx/HelloWorld/Welcome?name=Jessie&id=7
            return HttpUtility.HtmlEncode("Hello " + name + " , NumTimes is " + id);
        }
    }
}