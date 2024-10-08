﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Data;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class ItemsController : Controller
    {
        /*
        //Action Result
        public IActionResult Overview()             //item/overview
        {
            var item = new Item() { Name = "Item1"};
            return View(item);
        }
        //Action Parameters
        public IActionResult Edit(int id) {         //http://localhost:7221/items/edit/5
            return Content("id = " +  id);          //http://localhost:7221/items/edit?id=5 
        }
        */

        //CRUD operation
        private readonly MyAppContext _context;
        public ItemsController(MyAppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var item = await _context.Items.ToListAsync();                 //making it async
            return View(item);
        }
        public IActionResult Create() { 
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id, Name, Price")] Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Items.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(item);
        }
    }
}
