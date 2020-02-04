﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Capstone.Data;
using Capstone.Models.Data;
using Microsoft.AspNetCore.Identity;
using Capstone.Routes.V1;

namespace Capstone.Controllers.V1
{
    [ApiController]
    //[Route("api/[controller]/{dog}")]
    public class DogsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public DogsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }
        
        [HttpGet(Api.Dog.GetAll)]
        // GET: Dogs
        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            var applicationDbContext = _context.Dog.Select((dog) => new {dog.Name});
            return Ok(applicationDbContext);
        }

        [HttpGet(Api.Dog.Get)]
        // GET: Dogs/Details/
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dog = await _context.Dog.FirstOrDefaultAsync(m => m.Id == id);
            if (dog == null)
            {
                return NotFound();
            }

            return Ok(dog);
        }


        // GET: Dogs/Create

        //[HttpGet(Api.Dog.Get)]
        //public IActionResult Create()
        //{
        //    return Ok();
        //}

        // POST: Dogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost(Api.Dog.Post)]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Sex,Breed,Size,Description,Location,AnimalFriendly,CatFriendly,HouseTrained,LeashTrained,Neutered")] Dog dog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return Ok(dog);
        }

        // GET: Dogs/Edit/5
        
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var dog = await _context.Dog.FindAsync(id);
        //    if (dog == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(dog);
        //}

        // POST: Dogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost(Api.Dog.Post)]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Sex,Breed,Size,Description,Location,AnimalFriendly,CatFriendly,HouseTrained,LeashTrained,Neutered")] Dog dog)
        {
            if (id != dog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DogExists(dog.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return Ok(dog);
        }

        // GET: Dogs/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var dog = await _context.Dog
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (dog == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(dog);
        //}

        // POST: Dogs/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var dog = await _context.Dog.FindAsync(id);
        //    _context.Dog.Remove(dog);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool DogExists(int id)
        {
            return _context.Dog.Any(e => e.Id == id);
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

    }
}
