using Metroiten.Services;
using Microsoft.AspNetCore.Mvc;

namespace Metroiten.ViewComponents
{
    public class GreeterViewComponent : ViewComponent 
    {
        private readonly IGreeting _greeting;

        public GreeterViewComponent(IGreeting greeting)
        {
            _greeting = greeting;
        }

        public IViewComponentResult Invoke()
        {
            var model = _greeting.GetMessage();
            return View("Default", model);
        }
    }
}
