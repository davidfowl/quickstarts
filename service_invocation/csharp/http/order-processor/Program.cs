var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapPost("/orders", (Order order) =>
{
    Console.WriteLine("Order received : " + order);
    return order.ToString();
});

await app.RunAsync();

public record Order(int orderId);
