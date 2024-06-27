using FluentBuilderLibrary.Internal.Entities;
using FluentBuilderLibrary.Public;

namespace FluentBuilderLibrary.Internal.Builders;

internal class ProductBuilderStep3(string name, string description) : IProductBuilderForOptionalProperties
{
    private readonly string _name = name;
    private readonly string _description = description;
    private readonly CategoryBuilder _categoryBuilder = new();
    private readonly List<string> _tags = [];
    private string _property1 = "";
    private string _property2 = "";

    public IProductBuilderForOptionalProperties WithCategory(Action<ICategoryBuilder> config)
    {
        config(_categoryBuilder);
        return this;
    }

    public IProductBuilderForOptionalProperties WithTag(string tag)
    {
        _tags.Add(tag);
        return this;
    }

    public IProductBuilderForOptionalProperties WithProperty1(string property1)
    {
        _property1 = property1;
        return this;
    }

    public IProductBuilderForOptionalProperties WithProperty2(string property2)
    {
        _property2 = property2;
        return this;
    }

    public IProduct Build()
        => new Product()
        {
            Name = _name,
            Description = _description,
            Category = _categoryBuilder.Build(),
            Tags = _tags,
            Property1 = _property1,
            Property2 = _property2
        };
}
