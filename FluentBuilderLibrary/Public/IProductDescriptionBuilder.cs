namespace FluentBuilderLibrary.Public;

public interface IProductDescriptionBuilder
{
    IProductBuilderForOptionalProperties WithDescription(string description);
}