using FluentBuilderLibrary.Public;

namespace FluentBuilderLibrary.Internal.Builders;

internal class ProductNameBuilder : IProductNameBuilder
{
    public IProductDescriptionBuilder WithName(string name)
    {
        return new ProductDescriptionBuilder(name);
    }
}
