using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NETD3202_Lab5.Models;

namespace NETD3202_Lab5.Controllers
{
    public class PromptsController : Controller
    {
        private readonly PromptContext _context;

        public PromptsController(PromptContext context)
        {
            _context = context;
        }

        //GET: Prompts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Prompts.ToListAsync());
        }

        //GET: Prompts/Details
        public 
    }
}
