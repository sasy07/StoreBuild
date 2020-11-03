using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StoreBuild.Domain.Models.User
{
    public class UserSecurity
    {
        [Key]
        public int SecurityId { get; set; }

        [Required]
        public int UserId { get; set; }

        [DisplayName("سوال امنیتی")]
        public int QuestionId { get; set; }

        [DisplayName("کد احراز هویت")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(64, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string IdentificationCode { get; set; }

        [DisplayName("کد تایید")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(16, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public int ConfirmationCode { get; set; }

        [DisplayName("تاییدیه ایمیل")]
        public bool EmailConfirmation { get; set; }

        [DisplayName("تاییدیه موبایل")]
        public bool MobileConfirmation { get; set; }

        [DisplayName("تاییدیه تلفن ثابت")]
        public bool PhoneConfirmation { get; set; }

        [DisplayName("ورود دو مرحله ای")]
        public bool TwoFactorAuthentication { get; set; }

        #region Relations

        public User User { get; set; }

        #endregion
    }
}