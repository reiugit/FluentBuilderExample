# Guided Fluent Builder

## Example of creating a product with a 'Guided Fluent Builder'

 * The builder is a 'guided builder' with a sequence of steps.
 * The builder first enforces the required properties.
 * The builder then allows for all optional properties.
<br>

 * The desired product can only be instantiated via the builder.
 * Direct instantiation of a product is therefore prohibited.
<br>

 * Only the interface of the product is exposed to the client.
 * The resulting product is immutable.
<br>

 * The builder has a fluent syntax.
 * The builder handles a nested subclass with lambda syntax.
