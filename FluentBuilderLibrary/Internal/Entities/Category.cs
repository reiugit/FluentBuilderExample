using FluentBuilderLibrary.Public;

namespace FluentBuilderLibrary.Internal.Entities;

internal record Category() : ICategory
{
    public string Name { get; init; } = "";
    public string Description { get; init; } = "";

}