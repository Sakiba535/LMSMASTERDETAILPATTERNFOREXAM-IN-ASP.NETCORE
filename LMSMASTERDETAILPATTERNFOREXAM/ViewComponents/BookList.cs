using LMSMASTERDETAILPATTERNFOREXAM.Models;
using Microsoft.AspNetCore.Mvc;

namespace LMSMASTERDETAILPATTERNFOREXAM.ViewComponents
{
    public class BookList:ViewComponent
    {
        public IViewComponentResult Invoke(List<Book> data)
        {

            ViewBag.Count = data.Count;
            ViewBag.Total = data.Sum(i => i.RentPrice);

            return View(data);
        }
    }
}
