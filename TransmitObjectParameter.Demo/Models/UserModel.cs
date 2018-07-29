using GalaSoft.MvvmLight;

namespace TransmitObjectParameter.Demo.Models
{
    public class UserModel : ObservableObject
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
        public string Name
        {
            get => _name;
            set => Set(() => Name, ref _name, value);
        }

        /// <summary>
        /// 用户电话
        /// </summary>
        public string Phone
        {
            get => _phone;
            set => Set(() => Phone, ref _phone, value);
        }

        /// <summary>
        /// 用户邮件
        /// </summary>
        public string Email
        {
            get => _email;
            set => Set(() => Email, ref _email, value);
        }
    }
}
