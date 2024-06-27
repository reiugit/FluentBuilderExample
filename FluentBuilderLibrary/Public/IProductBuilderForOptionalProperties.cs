namespace FluentBuilderLibrary.Public;

public interface IProductBuilderForOptionalProperties
{
    IProduct Build();
    IProductBuilderForOptionalProperties WithCategory(Action<ICategoryBuilder> config);
    IProductBuilderForOptionalProperties WithProperty1(string property1);
    IProductBuilderForOptionalProperties WithProperty2(string property2);
    IProductBuilderForOptionalProperties WithTag(string tag);
}