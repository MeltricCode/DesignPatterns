using Builder.Concrete;
using Builder.Model;

// Builder Pattern:
// A creational design pattern that allows for the step-by-step construction of a complex object.
// It separates the construction of an object from its representation, so the same construction process
// can create different representations (objects).
// The Builder pattern is useful when creating objects with many optional parts or configurations,
// and allows you to construct an object incrementally, making the code more readable and maintainable.


SocialMediaPostBuilder builder = new SocialMediaPostBuilder();

SocialMediaPost post = builder
    .AddTitle("Book")
    .AddContent("This book is perfect")
    .AddAuthor("GOF")
    .AddDatePosted(DateTime.Now)
    .AddImageUri(new Uri("https://something.com"))
    .AddLinks(new List<string>() { "a.com", "b.com", "c.com" })
    .AddTags(new List<string>() { "Book", "DesignPattern", "System Design" })
    .Build();

Console.WriteLine(post.ToString());