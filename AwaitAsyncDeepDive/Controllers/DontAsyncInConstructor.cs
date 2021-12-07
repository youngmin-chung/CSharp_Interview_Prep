﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwaitAsyncDeepDive.Controllers
{
    public class DontAsyncInConstructor : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<string> InputOutput()
        {
           
        }
    }

    public class SomeObject
    {
        public SomeObject()
        {
            // never do async here.
        }

        public async Task<SomeObject> Create()
        {
            return new SomeObject();
        }
    }

    public class SomeObjectFactory
    {
        public SomeObjectFactory()
        {

        }
        public async Task<SomeObject> Create()
        {
            return new SomeObject();
        }

    }
}
