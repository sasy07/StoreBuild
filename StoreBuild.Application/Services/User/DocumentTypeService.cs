using StoreBuild.Application.Interfaces.User;
using StoreBuild.Domain.Interfaces.User;

namespace StoreBuild.Application.Services.User
{
    public class DocumentTypeService:IDocumentTypeService
    {
        private IDocumentTypeRepository _documentTypeRepository;

        public DocumentTypeService(IDocumentTypeRepository documentTypeRepository)
        {
            _documentTypeRepository = documentTypeRepository;
        }
    }
}