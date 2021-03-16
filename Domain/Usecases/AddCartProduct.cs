using crud.Domain.Entities;

namespace crud.Domain.Usecases
{
    public interface IAddCartProduct
    {
        void Execute(Product product);
    }
}