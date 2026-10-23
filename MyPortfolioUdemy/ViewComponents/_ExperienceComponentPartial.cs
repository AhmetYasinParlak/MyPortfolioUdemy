using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext porfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = porfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
