using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StoreBuild.Domain.Models.User
{
    public class UserAddress
    {
        public UserAddress()
        {
            
        }

        [Key]
        public int AddressId { get; set; }

        [DisplayName("کاربر")]
        [Required]
        public int UserId { get; set; }

        [DisplayName("شهر")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public int CityId { get; set; }

        [DisplayName("آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(2048, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Address { get; set; }

        [DisplayName("کد پستی")]
        [MaxLength(16, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string PostalCode { get; set; }

        #region Relations

        public User User { get; set; }
        public City City { get; set; }

        #endregion
    }
}
