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

    [HttpPost]
    public ActionResult<Order> Create([FromBody] List<OrderRequest> request)
    {
      Order o = new Order();
      try
      {
        request.ForEach(r => o.Pizzas.Add(r.FullfillReqest()));
        return o;
      }
      catch (System.Exception e)
      {
        return BadRequest(new { error = e.Message, StatusCode = 400 });
      }
    }
  }
}