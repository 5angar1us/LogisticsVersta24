using LogisticsVersta24.Extension;
using LogisticsVersta24.Models;
using LogisticsVersta24.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LogisticsVersta24.Controllers
{
    public class OrderController : Controller
    {
        public OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        // GET: OrderController1
        public ActionResult Index()
        {
            return View(_orderService.GetAll());
        }

        // GET: OrderController1/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_orderService.Get(id));

        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order order)
        {
            try
            {
                _orderService.Add(order);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: OrderController1/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_orderService.Get(id));
        }

        // POST: OrderController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
        {
            try
            {
                _orderService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
