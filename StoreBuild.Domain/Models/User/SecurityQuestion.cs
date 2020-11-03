using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StoreBuild.Domain.Models.User
{
    public class SecurityQuestion
    {
        public SecurityQuestion()
        {
            
        }

        [Key]
        public int QuestionId { get; set; }

        [DisplayName("سوال امنیتی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(512, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string QuestionTitle { get; set; }

        #region Relations

        public UserSecurity UserSecurity { get; set; }

        #endregion
    }
}
