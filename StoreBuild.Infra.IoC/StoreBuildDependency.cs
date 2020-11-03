using Microsoft.Extensions.DependencyInjection;
using StoreBuild.Application.Interfaces.User;
using StoreBuild.Application.Services.User;
using StoreBuild.Domain.Interfaces.User;
using StoreBuild.Infra.Data.Repository.User;

namespace StoreBuild.Infra.IoC
{
    public class StoreBuildDependency
    {
        public static void RegisterService(IServiceCollection service)
        {
            //Application Services

            #region Users Services

            service.AddScoped<ICityService, CityService>();
            service.AddScoped<IDocumentTypeService, DocumentTypeService>();
            service.AddScoped<ISecurityQuestionService, SecurityQuestionService>();
            service.AddScoped<IUserAddressService, UserAddressService>();
            service.AddScoped<IUserDocumentService, UserDocumentService>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IUserProfileService, UserProfileService>();
            service.AddScoped<IUserSecurityService, UserSecurityService>();
            service.AddScoped<ISecurityAnswerService, SecurityAnswerService>();

            #endregion

            //Infra Data Repository

            #region Users Repositories

            service.AddScoped<ICityRepository, CityRepository>();
            service.AddScoped<IDocumentTypeRepository, DocumentTypeRepository>();
            service.AddScoped<ISecurityQuestionRepository, SecurityQuestionRepository>();
            service.AddScoped<IUserAddressRepository, UserAddressRepository>();
            service.AddScoped<IUserDocumentRepository, UserDocumentRepository>();
            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<IUserProfileRepository, UserProfileRepository>();
            service.AddScoped<IUserSecurityRepository, UserSecurityRepository>();
            service.AddScoped<ISecurityAnswerRepository, SecurityAnswerRepository>();

            #endregion
        }
    }
}