using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kiwiho.example.Basket.API.Model;
using kiwiho.example.Basket.API.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace kiwiho.example.Basket.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BasketController : Controller
    {
        private readonly ILogger<BasketController> _logger;
        private readonly BasketRepository _repository;

        public BasketController(ILogger<BasketController> logger, BasketRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet("{id}")]
        public ActionResult<IList<CustomerBasket>> Get(string id)
        {
            return Json(_repository.Get(id) ?? new(id));
        }
    }
}
