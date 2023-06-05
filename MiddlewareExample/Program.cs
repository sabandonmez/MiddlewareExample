var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();


app.Use(async (context, next) =>
{
    Console.WriteLine("Start Use Middleware");
    await next.Invoke();
    Console.WriteLine("Stop Use Middleware");
});

app.Run(async context =>
{
    await context.Response.WriteAsync("Run Middleware");
});


app.UseStaticFiles();

app.UseRouting();


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


//app.Run();