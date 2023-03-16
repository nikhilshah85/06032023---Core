var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(employeeWebAPI.Models.EF.EmpManagementContext));
builder.Services.AddCors(accesspolicy =>
{
    accesspolicy.AddDefaultPolicy(pol =>
    {
        pol.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });

    //accesspolicy.AddPolicy("angularAppPolicy", policy => {
    //    string[] allowMethods =new string[2] { "GET", "POST" };
    //    policy.WithMethods(allowMethods);
    //    policy.WithOrigins("https://www.empmanagementangular.com");
    //});

    //accesspolicy.AddPolicy("reactAppPolicy", policy => {
    //    string[] allowMethods = new string[3] { "GET", "POST","DELETE" };
    //    policy.WithMethods(allowMethods);
    //    policy.WithOrigins("https://www.empmanagementreact.com");
    //});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(); //middleware

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
