using Services.Service.Category;
using Services.Service.PropertyItems;
using Services.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentaion.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;
        private IPropertyIetmsService _propertyService;

        public CategoryController(ICategoryService categoryService,
            IPropertyIetmsService propertyIetmsService)
        {
            _categoryService = categoryService;
            _propertyService = propertyIetmsService;
        }
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Add(AddCategoryVm vm)
        {
            _categoryService.add(vm);
            return View();
        }
        public ActionResult List()
        {
            var cats = _categoryService.GetAll();
            return View("CategoryList", cats);
        }

        public ActionResult Details(int id)
        {
            ViewBag.Cat = _categoryService.Get(id);
            var Props = _propertyService.GetAll(id);
            return View(Props);
        }
    }
}