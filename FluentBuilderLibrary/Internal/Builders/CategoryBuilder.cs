using FluentBuilderLibrary.Internal.Entities;
using FluentBuilderLibrary.Public;

namespace FluentBuilderLibrary.Internal.Builders;

internal class CategoryBuilder : ICategoryBuilder
{
    private string _name = "";
    private string _description = "";

    public ICategoryBuilder WithCategoryName(string name)
    {
        _name = name;
        return this;
    }
    public ICategoryBuilder WithCategoryDescription(string description)
    {
        _description = description;
        return this;
    }

    public ICategory Build()
    {
        return new Category()
        {
            Name = _name,
            Description = _description
        };
    }
}
