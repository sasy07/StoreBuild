using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StoreBuild.Domain.Models.User
{
    public class UserProfile
    {
        public UserProfile()
        {
            
        }

        [Key]
        public int ProfileId { get; set; }

        [DisplayName("کاربر")]
        [Required]
        public int UserId { get; set; }

        [DisplayName("نام")]
        [MaxLength(64, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Name { get; set; }

        [DisplayName("نام خانوادگی")]
        [MaxLength(64, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Family { get; set; }

        [DisplayName("آواتار")]
        [MaxLength(128, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Avatar { get; set; }

        [DisplayName("پست الکترونیک")]
        [MaxLength(256, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        [EmailAddress(ErrorMessage = "پست الکترونیک وارد شده صحیح نمی باشد")]
        public string Email { get; set; }

        [DisplayName("تلفن ثابت")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(16, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Phone { get; set; }

        [DisplayName("درباره من")]
        [MaxLength(2048, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Biography { get; set; }

        [DisplayName("تاریخ تولد")]
        public DateTime DateOfBirth { get; set; }

        #region Relations

        public User User { get; set; }

        #endregion
    }
}
