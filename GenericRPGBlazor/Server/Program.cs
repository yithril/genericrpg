using GenericRPGBlazor.Server.Data;
using GenericRPGBlazor.Server.GameLogic.Parser;
using GenericRPGBlazor.Server.GameLogic.Parser.Interface;
using GenericRPGBlazor.Server.Middleware;
using GenericRPGBlazor.Server.Services;
using GenericRPGBlazor.Server.Services.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<GameDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("GameDB")));

// Add services to the container.

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.Authority = builder.Configuration["Auth0:Authority"];
    options.Audience = builder.Configuration["Auth0:Audience"];
    options.TokenValidationParameters = new TokenValidationParameters
    {
        NameClaimType = ClaimTypes.NameIdentifier
    };
});

builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Generic RPG API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("read:admin", policy => policy.Requirements.Add(new HasScopeRequirement("read:admin", builder.Configuration["Auth0:Authority"])));
});

builder.Services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();

//Add services here, keeping them together makes it easier to se
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<IRaceService, RaceService>();
builder.Services.AddScoped<IArmorService, ArmorService>();
builder.Services.AddScoped<ICraftReagentService, CraftReagentService>();
builder.Services.AddScoped<ICraftRecipeService, CraftRecipeService>();
builder.Services.AddScoped<ICraftSkillService, CraftSkillService>();
builder.Services.AddScoped<IGameHelpService, GameHelpService>();
builder.Services.AddScoped<IGameZoneService, GameZoneService>();
builder.Services.AddScoped<IItemService, ItemService>();
builder.Services.AddScoped<ILimbService, LimbService>();
builder.Services.AddScoped<INPCService, NPCService>();
builder.Services.AddScoped<IPlayerQuestService, PlayerQuestService>();
builder.Services.AddScoped<IQuestService, QuestService>();
builder.Services.AddScoped<IRaceSkillService, RaceSkillService>();
builder.Services.AddScoped<IRoomExitService, RoomExitService>();
builder.Services.AddScoped<IRoomItemService, RoomItemService>();
builder.Services.AddScoped<IRoomNPCService, RoomNPCService>();
builder.Services.AddScoped<ISkillService, SkillService>();
builder.Services.AddScoped<IWeaponService, WeaponService>();
builder.Services.AddScoped<ICommandRouter, CommandRouter>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddSignalR();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blazor API V1");
    });
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
