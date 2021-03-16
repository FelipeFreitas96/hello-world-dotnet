using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using crud.Domain.Entities;
using crud.Data.Service;

namespace crud.Controllers
{
    [ApiController]
    [Route("/cart")]
    public class CartController : ControllerBase
    {
        private static readonly Dictionary<int, string> dic1 = new Dictionary<int, string>() {
            {2, "Banana"},
            {4, "Laranja"},
            {1, "Manga"},
            {3, "Abacate"},
            {6, "Maça"}
        };

        private readonly ILogger<CartController> _logger;

        public CartController(ILogger<CartController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            var cart = new Cart();
            var addCartProduct = new AddCartProductService(cart);

            foreach (KeyValuePair<int, string> item in dic1) {
                var product = new Product();
                product.name = item.Value;
                product.price = (uint) item.Key;
                addCartProduct.Execute(product);
            }
            
            var listCartProducts = new ListCartProductsService(cart);
            listCartProducts.Execute();
        }
    }
}
