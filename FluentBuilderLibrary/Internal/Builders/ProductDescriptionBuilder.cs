using FluentBuilderLibrary.Public;

namespace FluentBuilderLibrary.Internal.Builders;

internal class ProductDescriptionBuilder(string name) : IProductDescriptionBuilder
{
    public IProductBuilderForAllOptionalProperties WithDescription(string description)
    {
        return new ProductBuilderForAllOptionalProperties(name, description);
    }
}
