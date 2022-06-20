using Pokemon.TheBestTeam.Infrastructure.CrossCutting.IoC;

string originsPolicy = "AllowAllOrigins";
string[] headersExposed = new string[] { "Date", "Content-Type", "Content-Disposition", "Content-Length" };

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

_ = builder.Services.AddControllers();
_ = builder.Services.AddEndpointsApiExplorer();
_ = builder.Services.AddSwaggerGen();
_ = builder.Services.AddRouting(options => options.LowercaseUrls = true);
_ = builder.Services.AddCors(options =>
{
    options.AddPolicy(originsPolicy, builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().WithExposedHeaders(headersExposed));
});
_ = builder.Services.AddPostgresDbContext(builder.Configuration);
_ = builder.Services.AddInfrastructureAutoMapper();
_ = builder.Services.AddRelationalRepository();

var app = builder.Build();

_ = app.UseSwagger();
_ = app.UseSwaggerUI();
_ = app.UseRouting();
_ = app.UseRequestLocalization();
_ = app.UseCors(originsPolicy);
_ = app.UseHttpsRedirection();
_ = app.UseAuthorization();
_ = app.MapControllers();

app.Run();
