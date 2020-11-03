using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StoreBuild.Domain.Models.User
{
    public class SecurityAnswer
    {
        [Key]
        public int AnswerId { get; set; }

        [Required]
        public int QuestionId { get; set; }

        [Required]
        public int UserId { get; set; }

        [DisplayName("پاسخ")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(128, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Answer { get; set; }

        #region Relations

        public SecurityQuestion SecurityQuestion { get; set; }
        public User User { get; set; }

        #endregion
    }
}