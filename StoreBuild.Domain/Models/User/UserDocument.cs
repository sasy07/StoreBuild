using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StoreBuild.Domain.Models.User
{
    public class UserDocument
    {
        public UserDocument()
        {
            
        }

        [Key]
        public int DocumentId { get; set; }

        [DisplayName("کاربر")]
        [Required]
        public int UserId { get; set; }

        [DisplayName("نوع مدرک")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public int DocumentTypeId { get; set; }

        [DisplayName("مدرک")]
        [MaxLength(128, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Document { get; set; }

        [DisplayName("تاریخ درج")]
        public DateTime CreateDate { get; set; }

        [DisplayName("تایید شده")]
        public bool Accepted { get; set; }

        #region Relations

        public User User { get; set; }
        public DocumentType DocumentType { get; set; }

        #endregion
    }
}
