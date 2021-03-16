using crud.Domain.Usecases;
using crud.Domain.Entities;

namespace crud.Data.Service
{
    public class AddCartProductService : IAddCartProduct
    {
        private Cart cart;
        public AddCartProductService(Cart cart) {
            this.cart = cart;
        }
        public void Execute(Product product) {
            this.cart.products.Add(product);
        }
    }
}