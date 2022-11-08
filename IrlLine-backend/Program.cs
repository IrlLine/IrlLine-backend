using IrlLine_backend;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<UserService>();

var app = builder.Build();

app.MapGet("/users", () =>
{
    return UserService.GetAll();
});

app.MapGet("/users/{username}", (string username) =>
{
    var user = UserService.GetOneUser(username);
    return Results.Ok(user);
});

app.Run();
