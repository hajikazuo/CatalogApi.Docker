using Catalog.Api.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Data
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
