using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaperStore.Models;

namespace PaperStore.Controllers
{
    [Route("Company")]
    public class CompanyController : Controller
    {
        PaperContext _context;

        public CompanyController(PaperContext context)
        {
            _context = context;
        }
        [HttpGet("New")]
        public IActionResult NewCompany()
        {
            return View();
        }

        [HttpGet("List")]
        public IActionResult CompanyList()
        {
            return View(_context.Companies);
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
               var companyToDelete = _context.Companies.FirstOrDefault(x => x.Id == id);

                _context.Companies.Remove(companyToDelete);
                _context.SaveChanges();
                return View();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("Edit/{id}")]
        public IActionResult Edit(int id)
        {
            try
            {
                var companyToEdit = _context.Companies.FirstOrDefault(x => x.Id == id);

                return View(companyToEdit);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("Create")]
        public IActionResult Create(Company company)
        {
            try
            {
                _context.Companies.Add(company);
                _context.SaveChanges();
            }
           catch(Exception e)
            {
                return BadRequest(e.Message);
            }

            return null;
        }

    }
}