using FluentBuilderLibrary.Internal.Builders;
using FluentBuilderLibrary.Public;

namespace FluentBuilderLibrary;

public class ProductBuilder
{
    private ProductBuilder() { }

    public static IProductNameBuilder Empty() => new ProductBuilderStep1();
}
