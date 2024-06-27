namespace FluentBuilderLibrary.Public;

public interface IProductNameBuilder
{
    IProductDescriptionBuilder WithName(string name);
}