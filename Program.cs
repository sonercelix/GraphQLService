using GraphQLService.Mutations;
using GraphQLService.Queries;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// GraphQL servisini ekleyin
builder.Services.AddGraphQLServer()
    .AddQueryType<StudentQuery>()
    .AddMutationType<StudentMutation>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UsePlayground(new PlaygroundOptions
    {
        QueryPath = "/graphql",
        Path = "/playground"
    });
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// GraphQL Middleware'i kullanın
app.MapGraphQL();

app.Run();
