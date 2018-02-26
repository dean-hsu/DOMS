using DOMS.Interface.Service;
using DOMS.Model.DbModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DOMS.WebApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderService _orderService;

        public OrderController(ILogger<OrderController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View(_orderService.GetOrders(User.Identity.Name));
        }

        public IActionResult Create()
        {

            var order = new Order
            {
                UserName = User.Identity.Name,
                Status = OrderStatus.Ready,
                PaymentStatus = PaymentStatus.Unpaid
            };
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order entity)
        {
            try
            {
                return View();
            }
            catch
            {
                return View();
            }
        }

        private void InitializeOrder()
        {

        }
    }
}