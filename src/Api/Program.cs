using Api;

var builder = WebApplication.CreateBuilder(args);

// GraphQL sin DB, con un campo 'ping'
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

app.MapGraphQL("/graphql");

app.Run();