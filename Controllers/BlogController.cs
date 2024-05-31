﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace demo1.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm=new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            var values=bm.GetList();
            return View(values);
        }
    }
}