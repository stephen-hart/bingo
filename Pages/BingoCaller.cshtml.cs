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
            var numbers = new string[] {
                " Kellys eye, #1",
" One little duck, #2",
" Cup of tea, #3",
" Knock at the door, #4",
" Man alive, #5",
" Half a dozen, #6",
" Lucky seven, #7",
" Garden gate, #8",
" Doctors orders, #9",
" Boris Johnson’s den, #10",
" Legs eleven, #11",
" One dozen, #12",
" Unlucky for some, #13",
" Valentine’s Day, #14",
" Young and keen, #15",
" Sweet 16, #16",
" Dancing queen, #17",
" Coming of age, #18",
" Goodbye teens, #19",
" One score, #20",
" Key of the door, #21",
" Two little ducks, #22",
" Thee and me, #23",
" Two dozen, #24",
" Duck and dive, #25",
" Pick and mix, #26",
" Gateway to heaven, #27",
" In a state, #28",
" Rise and shine, #29",
" Dirty Gertie, #30",
" Get up and run, #31",
" Buckle my shoe, #32",
" All the threes, #33",
" Ask for more, #34",
" Jump and jive, #35",
" Three dozen, #36",
" More than eleven, #37",
" Christmas cake, #38",
" 39 steps, #39",
" Life begins, #40",
" Time for fun, #41",
" Winnie the Pooh, #42",
" Down on your knees, #43",
" Droopy drawers, #44",
" Halfway there, #45",
" Up to tricks, #46",
" Four and seven, #47",
" Four dozen, #48",
" PC, #49",
" Half a century, #50",
" Tweak of the thumb, #51",
" Danny La Rue, #52",
" Here comes Herbie, #53",
" Clean the floor, #54",
" Snakes alive, #55",
" Shotts Bus, #56",
" Heinz varieties, #57",
" Make them wait, #58",
" Brighton Line, #59",
" Five dozen, #60",
" Baker’s bun, #61",
" Tickety-boo, #62",
" Tickle me 63, #63",
" Red raw, #64",
" Old age pension, #65",
" Clickety click, #66",
" Stairway to heaven, #67",
" Saving Grace, #68",
" Favourite of mine, #69",
" Three score and ten, #70",
" Bang on the drum, #71",
" Six dozen, #72",
" Queen bee, #73",
" Hit the floor, #74",
" Strive and strive, #75",
" Trombones, #76",
" Sunset strip, #77",
" 39 more steps, #78",
" One more time, #79",
" Eight and blank, #80",
" Stop and run, #81",
" Straight on through, #82",
" Time for tea, #83",
" Seven dozen, #84",
" Staying alive, #85",
" Between the sticks, #86",
" Torquay in Devon, #87",
" Two fat ladies, #88",
" Nearly there, #89",
" Top of the shop, #90",
            };
         

            var highestNumber = 75;

            var toPickFrom = numbers.Take(highestNumber);

            var bingoNumbers = new List<string>();
            var pickedNumbers = new List<int>();

            var randomGenerator = new Random();

            for (var i = 0; i < highestNumber; i++)
            {
                int nextNumber;

                do
                {
                    nextNumber = randomGenerator.Next(1, (highestNumber + 1));
                }
                while (pickedNumbers.Contains(nextNumber));

                pickedNumbers.Add(nextNumber);

                bingoNumbers.Add(toPickFrom.ElementAt(nextNumber-1));
            }

            ViewData["BingoNumbers"] = bingoNumbers;

        }
    }
}