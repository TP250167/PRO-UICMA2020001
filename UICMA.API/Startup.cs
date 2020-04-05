using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NLog;
using UICMA.API.Extensions;
using UICMA.API.ViewModels.Mappings;
using UICMA.Repository;
using UICMA.Repository.ClaimRepository;
using UICMA.Repository.RARepository;
using UICMA.Service;
using UICMA.Service.ClaimServices;
using UICMA.Service.MasterData;
using UICMA.Service.RAService;

namespace UICMA.API
{
    public class Startup
    {
        private static string _applicationPath = string.Empty;
        private static string _contentRootPath = string.Empty;
        public IConfiguration Configuration { get; set; }
        public Startup(IHostingEnvironment env)
        {
            LogManager.LoadConfiguration(String.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            //Configuration = configuration;

            _applicationPath = env.WebRootPath;
            _contentRootPath = env.ContentRootPath;
            // Setup configuration sources.

            var builder = new ConfigurationBuilder()
                .SetBasePath(_contentRootPath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: false);

            if (env.IsDevelopment())
            {
                // This reads the configuration keys from the secret store.
                // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
                //builder.AddUserSecrets();
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        private static IHttpContextAccessor HttpContextAccessor;

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {

            var Audiance = Configuration.GetValue<string>("Audiance");
            var Authority = Configuration.GetValue<string>("Authority");

            services.AddCors(options => {
                options.AddPolicy("CorsPolicy",
                    Configuration => Configuration.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            services.AddAuthentication("Bearer")
               .AddJwtBearer(options =>
               {
                   options.Authority = $"https://login.microsoftonline.com/" + Authority;
                   options.Audience = Audiance;
                   options.RequireHttpsMetadata = false;
                   options.TokenValidationParameters = new TokenValidationParameters()
                   {
                       //ValidAudience = "microsoft:identityserver:e7e9d0c2-cb98-4974-b532-2c6776d5e379",
                       //ValidIssuer = "http://DC02.kosoft.co/adfs/services/trust"

                       ValidateIssuer = true,
                       ValidIssuer = Authority,

                       ValidateAudience = true,
                       ValidAudience = Audiance,
                   };
                   options.Events = new JwtBearerEvents
                   {
                       OnTokenValidated = async ctx =>
                       {
                           var claims = new List<Claim>
                           {
                                new Claim("BasicClaim", "UserInfo")
                           };

                           ctx.Principal.AddIdentity(new ClaimsIdentity(claims));
                       }
                   };
               });
            services.AddMvc(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                   .AddAuthenticationSchemes("Bearer")
                   .RequireAuthenticatedUser()
                   .Build();

                options.Filters.Add(new AuthorizeFilter(policy));
            });
            services.AddAuthorization(options =>
            {
                options.AddPolicy("UICMA Policy", policy => policy.RequireClaim("BasicClaim", "UserInfo"));
            });

            services.AddDbContext<UICMAContext>(options =>
               options.UseSqlServer(Configuration["Data:UICMAConnection:ConnectionString"],
               b => b.MigrationsAssembly("UICMA.API")));

            services.AddMvc(config=> {
                config.RespectBrowserAcceptHeader = true;
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            services.AddSingleton<ILoggerManager, LoggerManager>();
            services.AddScoped<ModelValidationAttribute>();


            // Automapper Configuration
            //  AutoMapperConfiguration.Configure();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DomainToViewModelMappingProfile());
               

            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            // Enable Cors
            services.AddCors();

            // Add MVC services to the services container.
            services.AddMvc()
                .AddJsonOptions(opts =>
                {
                    // Force Camel Case to JSON
                    opts.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    opts.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            var builder = new ContainerBuilder();
            builder.RegisterType<ScheduleRepository>().As<IScheduleRepository>();
            builder.RegisterType<ScheduleService>().As<IScheduleService>();
            


                
            //Claim  Repository and Service 
            builder.RegisterType<ClaimAppealService>().As<IClaimAppealService>();
            builder.RegisterType<ClaimAppealRepository>().As<IClaimAppealRepository>();


            builder.RegisterType<ClaimInterviewService>().As<IClaimInterviewService>();
            builder.RegisterType<ClaimInterviewRepository>().As<IClaimInterviewRepository>();

            builder.RegisterType<ClaimResponseService>().As<IClaimResponseService>();
            builder.RegisterType<ClaimResponseRepository>().As<IClaimResponseRepository>();

            builder.RegisterType<ClaimDeterminationService>().As<IClaimDeterminationService>();
            builder.RegisterType<ClaimDeterminationRepository>().As<IClaimDeterminationRepository>();
                       
            builder.RegisterType<AdditionalInfoService>().As<IAdditionalInfoService>();
            builder.RegisterType<AdditionalInfoRepository>().As<IAdditionalInfoRepository>();
            
            builder.RegisterType<ALJDecisionService>().As<IALJDecisionService>();
            builder.RegisterType<ALJDecisionRepository>().As<IALJDecisionRepository>();
            
            builder.RegisterType<CUIABAcknowService>().As<ICUIABAcknowService>();
            builder.RegisterType<CUIABAcknowRepository>().As<ICUIABAcknowRepository>();


            builder.RegisterType<AttendeeService>().As<IAttendeeService>();
            builder.RegisterType<AttendeeRepository>().As<IAttendeeRepository>();

            builder.RegisterType<BenefitAuditService>().As<IBenefitAuditService>();
            builder.RegisterType<BenefitAuditRepository>().As<IBenefitAuditRepository>();


            builder.RegisterType<BenefitChargeService>().As<IBenefitChargeService>();
            builder.RegisterType<BenefitChargeRepository>().As<IBenefitChargeRepository>();

            builder.RegisterType<ClaimExceptionService>().As<IClaimExceptionService>();
            builder.RegisterType<ClaimExceptionRepository>().As<IClaimExceptionRepository>();

            builder.RegisterType<CUIABBoardAppealService>().As<ICUIABBoardAppealService>();
            builder.RegisterType<CUIABBoardAppealRepository>().As<ICUIABBoardAppealRepository>();

            builder.RegisterType<DeterminationAppealService>().As<IDeterminationAppealService>();
            builder.RegisterType<DeterminationAppealRepository>().As<IDeterminationAppealRepository>();

            builder.RegisterType<HearingService>().As<IHearingService>();
            builder.RegisterType<HearingRepository>().As<IHearingRepository>();

            builder.RegisterType<QuestionsService>().As<IQuestionsService>();
            builder.RegisterType<QuestionsRepository>().As<IQuestionsRepository>();

            builder.RegisterType<RequestForEmpDataService>().As<IRequestForEmpDataService>();
            builder.RegisterType<RequestForEmpDataRepository>().As<IRequestForEmpDataRepository>();

            builder.RegisterType<RequestToReopenService>().As<IRequestToReopenService>();
            builder.RegisterType<RequestToReopenRepository>().As<IRequestToReopenRepository>();

            builder.RegisterType<WagesService>().As<IWagesService>();
            builder.RegisterType<WagesRepository>().As<IWagesRepository>();

            builder.RegisterType<WagesAppealService>().As<IWagesAppealService>();
            builder.RegisterType<WagesAppealRepository>().As<IWagesAppealRepository>();

            builder.RegisterType<WritService>().As<IWritService>();
            builder.RegisterType<WritRepository>().As<IWritRepository>();

            builder.RegisterType<MDDocumentService>().As<IMDDocumentService>();
            builder.RegisterType<MDDocumentRepository>().As<IMDDocumentRepository>();

            builder.RegisterType<MDFormService>().As<IMDFormService>();
            builder.RegisterType<MDFormRepository>().As<IMDFormRepository>();





            //RA  Repository and Service 
            builder.RegisterType<RABatchService>().As<IRABatchService>();
            builder.RegisterType<RABatchRepository>().As<IRABatchRepository>();
            builder.RegisterType<RARecipientService>().As<IRARecipientService>();
            builder.RegisterType<RARecipientRepository>().As<IRARecipientRepository>();
            builder.RegisterType<RAScheduleRepository>().As<IRAScheduleRepository>();
            builder.RegisterType<RABatchScheduleRepository>().As<IRABatchScheduleRepository>();
            builder.RegisterType<EmployeeInfoDataRepository>().As<IEmployeeInfoDataRepository>();
            builder.RegisterType<RABatchRecipientRepository>().As<IRABatchRecipientRepository>();
            builder.RegisterType<TemplateRepository>().As<ITemplateRepository>();
            builder.RegisterType<RARecipientRuleService>().As<IRARecipientRuleService>();
            builder.RegisterType<RARecipientRuleRepository>().As<IRARecipientRuleRepository>();
            builder.RegisterType<RABatchRecipientRuleRepository>().As<IRABatchRecipientRuleRepository>();
            builder.RegisterType<RATemplateService>().As<IRATemplateService>();
            builder.RegisterType<TemplateRepository>().As<ITemplateRepository>();
            //RA Repository and Service End


            builder.RegisterType<FormDocumentMapService>().As<IFormDocumentMapService>();
            builder.RegisterType<FormDocumentMapRepository>().As<IFormDocumentMapRepository>();

            builder.RegisterType<IssuesListService>().As<IIssuesListService>();
            builder.RegisterType<IssuesListRepository>().As<IIssuesListRepository>();
            
            builder.RegisterType<NewClaimService>().As<INewClaimService>();
            builder.RegisterType<NewClaimRepository>().As<INewClaimRepository>();

            builder.RegisterType<ResponsetoEmployerService>().As<IResponsetoEmployerService>();
            builder.RegisterType<ResponsetoEmployerRepository>().As<IResponsetoEmployerRepository>();


            builder.RegisterType<WagesAfterAppealService>().As<IWagesAfterAppealService>();
            builder.RegisterType<WagesAfterAppealRepository>().As<IWagesAfterAppealRepository>();

            builder.RegisterType<NotificationService>().As<INotificationService>();
            builder.RegisterType<NotificationRepository>().As<INotificationRepository>();

                                                                        
            ////////////////




            builder.Populate(services);
            var container = builder.Build();
            //Create the IServiceProvider based on the container.
            return new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,ILoggerManager logger)
        {
            app.UseStaticFiles();
            // Add MVC to the request pipeline.
            app.UseCors(builder =>
                builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.ConfigureExceptionHandler(logger);

            app.UseHttpsRedirection();
            
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Values}/{action=Get}/{id?}");

                // Uncomment the following line to add a route for porting Web API 2 controllers.
                //routes.MapWebApiRoute("DefaultApi", "api/{controller}/{id?}");
            });
        }
    }
}
