using FluentBuilderLibrary;

// Example of creating a product with a 'Guided Fluent Builder'

// * The builder is a 'guided builder' with a sequence of steps.
// * The builder first enforces the required properties.
// * The builder then allows for all optional properties.

// * The desired product can only be instantiated via the builder.
// * Direct instantiation of a product is therefore prohibited.

// * Only the interface of the product is exposed to the client.
// * The resulting product is immutable.

// * The builder handles a nested subclass with lambda syntax.
// * The builder has a fluent syntax.

var product = ProductBuilder
    .Empty()
    .WithName($"Product A")
    .WithDescription("Product Description")
    .WithCategory(c => c
        .WithCategoryName("Category C1")
        .WithCategoryDescription("Category Description"))
    .WithTag("Tag X")
    .WithTag("Tag Y")
    .WithProperty2("Optional Property")
    .Build();

Console.WriteLine($"\nThe product '{product.Name}' was successfully created via the 'Guided Fluent Builder'.");
Console.WriteLine($"\nThe type of the product is '{product.GetType()}'");

Console.WriteLine();


