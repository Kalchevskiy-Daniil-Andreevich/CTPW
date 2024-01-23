var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "GETMO1",
        pattern: "/MResearch/M01/1",
        defaults: new { controller = "TMResearch", action = "GETM01" });
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "GETMO1_2",
        pattern: "/MResearch/M01",
        defaults: new { controller = "TMResearch", action = "GETM01" });
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "GETMO1_3",
        pattern: "/MResearch",
        defaults: new { controller = "TMResearch", action = "GETM01" });
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "GETMO1_4",
        pattern: "/",
        defaults: new { controller = "TMResearch", action = "GETM01" });
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "GETMO1_5",
        pattern: "V2/MResearch/M01",
        defaults: new { controller = "TMResearch", action = "GETM01" });
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "GETMO1_6",
        pattern: "V3/MResearch/{str}/M01",
        defaults: new { controller = "TMResearch", action = "GETM01" });
});



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "GETM02",
        pattern: "/V2",
        defaults: new { controller = "TMResearch", action = "GETM02" });
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "GETM02_2",
        pattern: "/V2/MResearch",
        defaults: new { controller = "TMResearch", action = "GETM02" });
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "GETM02_3",
        pattern: "/V2/MResearch/M02",
        defaults: new { controller = "TMResearch", action = "GETM02" });
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "GETM02_4",
        pattern: "/MResearch/M02",
        defaults: new { controller = "TMResearch", action = "GETM02" });
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "GETM02_5",
        pattern: "V3/MResearch/{str}/M02",
        defaults: new { controller = "TMResearch", action = "GETM02" });
});



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "GETM03",
        pattern: "/V3",
        defaults: new { controller = "TMResearch", action = "GETM03" });
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "GETM03",
        pattern: "/V3/MResearch/{str}",
        defaults: new { controller = "TMResearch", action = "GETM03" });
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "GETM03",
        pattern: "/V3/MResearch/{str}/M03",
        defaults: new { controller = "TMResearch", action = "GETM03" });
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "MXX",
        pattern: "{**uri}",
        defaults: new { controller = "TMResearch", action = "MXX" });
});

app.Run();
