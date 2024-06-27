using FluentBuilderLibrary.Public;

namespace FluentBuilderLibrary.Internal.Builders;

internal class ProductBuilderStep2(string name) : IProductDescriptionBuilder
{
    public IProductBuilderForOptionalProperties WithDescription(string description)
    {
        return new ProductBuilderStep3(name, description);
    }
}
