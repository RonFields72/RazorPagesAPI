using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UBH.RazorPagesAPI.Pages
{
    public class StarWarsFinderModel : PageModel
    {
        private static readonly List<string> Characters = new List<string>();

        static StarWarsFinderModel()
        {
            // Mocking out some data being returned from a call
            Characters.Add("Han Solo");
            Characters.Add("Chewbacca");
            Characters.Add("Princess Leia");
            Characters.Add("Luke Skywalker");
            Characters.Add("Darth Vader");
            Characters.Add("Boba Fett");
            Characters.Add("C3PO");
            Characters.Add("R2-D2");
            Characters.Add("Jawa");
            Characters.Add("Obi-Wan Kenobi");
        }
        public JsonResult OnGet()
        {
            var randomIndex = new Random().Next(Characters.Count - 1);
            return new JsonResult(Characters[randomIndex]);
        }
    }
}