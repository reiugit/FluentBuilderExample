using FluentBuilderLibrary.Public;

namespace FluentBuilderLibrary.Internal.Entities;

internal class Product : IProduct
{
    public string Name { get; init; } = "";
    public string Description { get; init; } = "";
    public ICategory Category { get; init; } = new Category();
    public List<string> Tags { get; init; } = [];
    public string Property1 { get; init; } = "";
    public string Property2 { get; init; } = "";
}