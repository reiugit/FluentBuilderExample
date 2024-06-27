namespace FluentBuilderLibrary.Public;

public interface IProductDescriptionBuilder
{
    IProductBuilderForAllOptionalProperties WithDescription(string description);
}