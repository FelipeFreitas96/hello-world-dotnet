using System;
using crud.Domain.Usecases;
using crud.Domain.Entities;

namespace crud.Data.Service
{
    public class ListCartProductsService : IListCartProducts
    {
        private Cart cart;
        public ListCartProductsService(Cart cart) {
            this.cart = cart;
        }
        public void Execute() {
            this.cart.products.ForEach(delegate(Product product) {
                Console.WriteLine(
                    string.Format(
                        "{0} - Price: R$ {1}", 
                        product.name,
                        product.price
                    )
                );
            });
        }
    }
}