using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace FormValidate.Demo.Models
{
    public class UserModel : ValidateModelBase
    {
        private string _name;
        private string _email;
        private string _phone;

        public UserModel()
        {

        }
        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        public string Name
        {
            get => _name;
            set => Set(() => Name, ref _name, value);
        }

        /// <summary>
        /// 用户电话
        /// </summary>
        [Required]
        [RegularExpression(@"^[-]?[1-9]{8,11}\d*$|^[0]{1}$", ErrorMessage = "用户电话必须为8-11位的数值.")]
        public string Phone
        {
            get => _phone;
            set => Set(() => Phone, ref _phone, value);
        }

        /// <summary>
        /// 用户邮件
        /// </summary>
        [Required]
        [StringLength(100, MinimumLength = 2)]
        [RegularExpression("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$", ErrorMessage = "请填写正确的邮箱地址.")]
        public string Email
        {
            get => _email;
            set => Set(() => Email, ref _email, value);
        }
    }
}
