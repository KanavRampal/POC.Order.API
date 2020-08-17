using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POC.Order.API.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet, Route("")]
        public IEnumerable<Order> Get()
        {
            List<Order> retVal = new List<Order>();
            retVal.Add(new Order(1, 250, DateTime.Parse("14-Apr-2020").Date));
            retVal.Add(new Order(2, 450, DateTime.Parse("15-Apr-2020").Date));
            return retVal;
            //List<Order> retVal =  GetOrderList();
            //return retVal;
        }

        private List<Order> GetOrderList()
        {
            List<Order> retVal = new List<Order>();
            retVal.Add(new Order(1, 250, DateTime.Parse("14-Apr-2020")));
            retVal.Add(new Order(2, 450, DateTime.Parse("15-Apr-2020")));
            return  retVal;
        }
    }
}