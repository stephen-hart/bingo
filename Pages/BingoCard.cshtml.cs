using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace bingo.Pages
{
    public class BingoCardModel : PageModel
    {
        public void OnGet()
        {
            var numberCount = 25;
            var highestNumber = 75;

            if (numberCount > highestNumber)
                throw new ArgumentException($"numberCount '{numberCount}' cannot exceed highestNumber '{highestNumber}'");

            var bingoNumbers = new List<int>();

            var randomGenerator = new Random();

            for(var i = 0; i < numberCount; i++)
            {
                int nextNumber;
                
                do
                {
                    nextNumber = randomGenerator.Next(1, highestNumber);
                }
                while (bingoNumbers.Contains(nextNumber));
                
                bingoNumbers.Add(nextNumber);
            }

            ViewData["BingoNumbers"] = bingoNumbers;
        }
    }
}
