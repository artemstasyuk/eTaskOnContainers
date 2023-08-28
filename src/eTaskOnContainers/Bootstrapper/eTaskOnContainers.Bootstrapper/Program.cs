using Fitfuel.Notifications.API;
using Fitfuel.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    //.AddWorkoutsModule(builder.Configuration)
    .AddNotificationsModule(builder.Configuration)
    .AddSharedFramework(builder.Configuration, builder.Host);
    //.AddAuthModule(builder.Configuration)

var app = builder.Build();
{
    app.UseSharedFramework(app.Environment);
    app.UseNotificationsModule();
    app.MapControllers();
}
app.Run();