using CatalogApi.Docker.Entities;
using MongoDB.Driver;

namespace CatalogApi.Docker.Data
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
