using Microsoft.AspNetCore.Mvc;
using Northwind.DAL.Abstract;

namespace Core6Mvc.Controllers
{

    public class CategoryController : Controller
    {
        private readonly ICategoryDal categoryDal;

        public CategoryController(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public IActionResult Index()
        {
            var result = categoryDal.GetAll();
            return View(result);
        }
    }
}
