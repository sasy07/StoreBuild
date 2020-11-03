using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBuild.Domain.Models.User
{
    public class DocumentType
    {
        public DocumentType()
        {
            
        }

        public int DocumentTypeId { get; set; }
        public string Title { get; set; }

        #region Relations

        public List<UserDocument> UserDocuments { get; set; }

        #endregion
    }
}
