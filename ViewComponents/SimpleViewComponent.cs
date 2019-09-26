using Microsoft.AspNetCore.Mvc;

namespace DAWAViewComponent.ViewComponents
{
    [ViewComponent(Name = "DAWAViewComponent.Simple")]
    public class SimpleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //var address = new Models.Address();
            return View();
        }
    }
}
