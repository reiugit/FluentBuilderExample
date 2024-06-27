namespace FluentBuilderLibrary.Public;

public interface IProductBuilderForAllOptionalProperties
{
    IProduct Build();
    IProductBuilderForAllOptionalProperties WithCategory(Action<ICategoryBuilder> config);
    IProductBuilderForAllOptionalProperties WithProperty1(string property1);
    IProductBuilderForAllOptionalProperties WithProperty2(string property2);
    IProductBuilderForAllOptionalProperties WithTag(string tag);
}