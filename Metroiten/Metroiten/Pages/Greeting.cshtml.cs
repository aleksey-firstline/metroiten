using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metroiten.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Metroiten.Pages
{
    public class GreetingModel : PageModel
    {
        private IGreeting _greeting;

        public GreetingModel(IGreeting greeting)
        {
            _greeting = greeting;
        }

        public string CurrentGreeting { get; private set; }

        public void OnGet(string name)
        {
            CurrentGreeting = $"{name} : {_greeting.GetMessage()}";
        }
    }
}