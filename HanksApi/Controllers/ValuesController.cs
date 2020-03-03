using System;
using HanksApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HanksApi.Controllers
{
    [Area("Api")]
    public class MobileMPController : ControllerBase
    {
        [HttpGet]
        public ActionResult<object> Authenticate(string key)
        {
            if (key != "correctKey")
            {
                return Unauthorized();
            }

            var obj = new { authKey = Guid.NewGuid().ToString() };
            return obj;
        }


        public ActionResult<OrderView[]> GetOrdersByDay(DateTime orderDay)
        {
            return OrderView.GenerateMock();
        }

        [HttpPost]
        public ActionResult UpdateOrder([FromBody] UpdateOrderCommand command)
        {
            var validGuid = Guid.Parse("680D29D4-A612-4BBD-B971-9B24265DF47B");

            if (command.OrderId != validGuid)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
