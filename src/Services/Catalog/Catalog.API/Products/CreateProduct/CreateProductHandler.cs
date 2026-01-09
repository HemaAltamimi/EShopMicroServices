using Catalog.API.Models;
using EShop.Framework.CQRS;

namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
    : ICommand<CreateProductResult>;
public record CreateProductResult(Guid Id);


internal class CreateProductCommandHandler : ICommndHandler<CreateProductCommand, CreateProductResult>
{

    public async Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Category = request.Category,
            Name = request.Name,
            ImageFile = request.ImageFile,
            Description = request.Description,
            Price = request.Price,
        };

        // Save DB

        return new CreateProductResult(Guid.NewGuid());
    }

}
