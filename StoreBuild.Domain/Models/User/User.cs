using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StoreBuild.Domain.Models.User
{
    public class User
    {
        public User()
        {
            
        }

        [Key]
        public int UserId { get; set; }

        [DisplayName("موبایل")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(16, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Mobile { get; set; }

        [DisplayName("کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(64, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Password { get; set; }

        [DisplayName("IP ثبت نام")]
        [MaxLength(32, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string RegisterIp { get; set; }

        [DisplayName("IP آخرین ورود")]
        [MaxLength(32, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string LastLoginIp { get; set; }

        [DisplayName("تاریخ ثبت نام")]
        public DateTime CreateDate { get; set; } = DateTime.Now;

        [DisplayName("تاریخ آخرین ورود")]
        public DateTime LastLoginDate { get; set; }

        [DisplayName("وضعیت")]
        public bool Status { get; set; }

        [DisplayName("فعال")]
        public bool IsActive { get; set; }

        [DisplayName("حذف شده")]
        public bool IsDelete { get; set; }

        #region Relations

        public List<UserProfile> UserProfiles { get; set; }
        public List<UserAddress> UserAddresses { get; set; }
        public List<UserDocument> UserDocuments { get; set; }
        public List<UserSecurity> UserSecurities { get; set; }
        public List<SecurityAnswer> SecurityAnswers { get; set; }

        #endregion
    }
}
