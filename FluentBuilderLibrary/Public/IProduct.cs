namespace FluentBuilderLibrary.Public;

public interface IProduct
{
    string Description { get; init; }
    string Name { get; init; }
    ICategory Category { get; init; }
    List<string> Tags { get; init; }
    string Property1 { get; init; }
    string Property2 { get; init; }
}