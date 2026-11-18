using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents.LayoutVeiwComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = context.ToDoLists.Count(x => x.Status == false);
            var values = context.ToDoLists.Where(x=>x.Status == false).ToList();
            return View(values);
        }
    }
}
