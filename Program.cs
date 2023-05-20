using ASP.NET_API.Helpers;
using ASP.NET_API.Repositories;
using ASP.NET_API.Repositories.Impl;
using ASP.NET_API.Services;
using ASP.NET_API.Services.Impl;
using ASP.NET_API.Settings;
using Microsoft.OpenApi.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

var builder = WebApplication.CreateBuilder(args);

// Configure getting and inserting Guid for MongoDB
#pragma warning disable CS0618
BsonDefaults.GuidRepresentation = GuidRepresentation.Standard;
BsonDefaults.GuidRepresentationMode = GuidRepresentationMode.V3;
#pragma warning restore CS0618
BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.Standard));


// Add config props
builder.Services.Configure<MongoDBSettings>(
    builder.Configuration.GetSection("MongoDB"));

// Add services to the container.
builder.Services.AddTransient<INewsService, NewsService>();
builder.Services.AddTransient<IAttachmentService, AttachmentService>();

// Add repositories to the container.
builder.Services.AddScoped<IPostRepository, PostRepository>();


builder.Services.AddControllers().AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Simple API example", Version = "v0.2" });

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseMiddleware<MiddlewareExceptions>();

app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

app.MapControllers();

app.Run();
