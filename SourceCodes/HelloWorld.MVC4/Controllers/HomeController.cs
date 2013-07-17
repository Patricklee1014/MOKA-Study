using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.MVC4.Models;
using HelloWorld.Services;

namespace HelloWorld.MVC4.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/

		public ActionResult Index()
		{
			ViewBag.HelloWorld = "Hello World from ViewBag";
			ViewData["HelloWorld2"] = "Hello World from ViewData";

			var service = new HelloWorldService();
			var vm = new HomeIndexViewModel();
			vm.HelloWorld = service.GetOutput("Hello World MVC4");

			return View(vm);
		}

	}
}
