using FluentBuilderLibrary.Public;

namespace FluentBuilderLibrary.Internal.Builders;

internal class ProductBuilderStep1 : IProductNameBuilder
{
    public IProductDescriptionBuilder WithName(string name)
    {
        return new ProductBuilderStep2(name);
    }
}
