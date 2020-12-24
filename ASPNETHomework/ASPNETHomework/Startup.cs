using System;
using System.Text;
using ASPNETHomework.Common;
using ASPNETHomework.DAL.Bootstrap;
using ASPNETHomework.Infrastructure;
using ASPNETHomework.Infrastructure.Interfaces;
using ASPNETHomework.Repositories.Bootstrap;
using ASPNETHomework.Services.Bootstrap;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace ASPNETHomework
{
	public class Startup
	{
		private string _moviesApiKey = null;
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			_moviesApiKey = Configuration["Movies:ServiceApiKey"];

			services.ConfigureDb(Configuration);
			services.ConfigureRepositories();
			services.AddControllers();
			var jwtTokenConfig = Configuration.GetSection("JwtTokenConfigUserSecret").Get<JwtTokenConfig>();
			services.AddSingleton(jwtTokenConfig);
			//add auth
			services.AddAuthentication(x =>
			{
				x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			}).AddJwtBearer(x =>
			{
				// the authentication requires HTTPS for the metadata address or authority
				x.RequireHttpsMetadata = true;
				// saves the JWT access token in the current HttpContext,
				x.SaveToken = true;
				x.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuer = true,
					ValidIssuer = jwtTokenConfig.Issuer,
					ValidateIssuerSigningKey = true,
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtTokenConfig.Secret)),
					ValidAudience = jwtTokenConfig.Audience,
					ValidateAudience = true,
					ValidateLifetime = true,
					ClockSkew = TimeSpan.FromMinutes(1)
				};
			}); 

			services.AddSingleton<IJwtAuthManager, JwtAuthManager>();
			services.AddHostedService<JwtRefreshTokenCache>();
			services.ConfigureServices();
			services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "JWT Auth Demo", Version = "v1" });

				var securityScheme = new OpenApiSecurityScheme
				{
					Name = "JWT Authentication",
					Description = "Enter JWT Bearer token **_only_**",
					In = ParameterLocation.Header,
					Type = SecuritySchemeType.Http,
					Scheme = "bearer",
					BearerFormat = "JWT",
					Reference = new OpenApiReference
					{
						Id = JwtBearerDefaults.AuthenticationScheme,
						Type = ReferenceType.SecurityScheme
					}
				};
				c.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme);
				c.AddSecurityRequirement(new OpenApiSecurityRequirement
				{
					{securityScheme, new string[] { }}
				});
			}); 
			services.AddCors(options =>
			{
				options.AddPolicy("AllowJwtDemo",
					builder =>
					{
						// white list
						builder.WithOrigins("http://localhost:4200");
						// we have only 3 methods in app, add its.
						builder.WithMethods("GET", "POST", "OPTIONS");
						// in request head
						builder.AllowAnyHeader();
						// lifetime
						builder.SetPreflightMaxAge(TimeSpan.FromSeconds(2520));
					});
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("./swagger/v1/swagger.json", "JWT Auth Demo V1");
				c.DocumentTitle = "JWT Auth Demo";
				c.RoutePrefix = string.Empty;
			});

			

			

			

			
			app.UseOpenApi();
			app.UseSwaggerUi3();
			app.UseRouting();
			app.UseCors("AllowJwtDemo");

			app.UseAuthentication();

			app.UseAuthorization();


			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
