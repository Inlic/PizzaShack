using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaShack.Mock;
using PizzaShack.Models;

namespace PizzaShack.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class OrdersController : ControllerBase
  {
    [HttpGet]
    public ActionResult<IEnumerable<Order>> Get()
    {
      return FakeDb.Orders;
    }
  }
}