using Builder.Concrete;
using Builder.Model;

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