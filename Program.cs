var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() {Title= "TigerTix API", Version="v1"});
});

builder.Services.AddRazorPages();
builder.Services.AddControllers();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

//app.MapGet("/", () => "Hello World!");
app.UseDefaultFiles();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=App}/{action=Index}/{id?}");

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint(
    "TigerTix-Project/apis/checkout.yaml", "v1"
    ));

app.Run();
