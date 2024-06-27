namespace FluentBuilderLibrary.Public;

public interface ICategoryBuilder
{
    ICategoryBuilder WithCategoryName(string name);
    ICategoryBuilder WithCategoryDescription(string description);
    ICategory Build();
}