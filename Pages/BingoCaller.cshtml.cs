using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace bingo.Pages
{
    public class BingoCallerModel : PageModel
    {
        public void OnGet()
        {
            var randomGenerator = new Random();

            ViewData["RandomNumber"] = randomGenerator.Next(1, 75);
        }
    }
}