﻿using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		public PartialViewResult CommentListByBLOG()
		{
			return PartialView();
		}
	}
}
