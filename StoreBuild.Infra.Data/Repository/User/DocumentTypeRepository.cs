using StoreBuild.Domain.Interfaces.User;

namespace StoreBuild.Infra.Data.Repository.User
{
    public class DocumentTypeRepository:IDocumentTypeRepository
    {
        private StoreBuildDbContext _context;

        public DocumentTypeRepository(StoreBuildDbContext context)
        {
            _context = context;
        }
        
    }
}