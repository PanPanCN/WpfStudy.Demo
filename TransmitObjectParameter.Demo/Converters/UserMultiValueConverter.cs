using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using TransmitObjectParameter.Demo.Models;

namespace TransmitObjectParameter.Demo.Converters
{
    public class UserMultiValueConverter : IMultiValueConverter
    {
        /// <inheritdoc />
        /// <summary>
        /// 对象转换
        /// </summary>
        /// <param name="values">所绑定的源的值</param>
        /// <param name="targetType">目标的类型</param>
        /// <param name="parameter">绑定时所传递的参数</param>
        /// <param name="culture">系统语言等信息</param>
        /// <returns></returns>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Cast<string>().Any(string.IsNullOrEmpty) && values.Length != 3)
            {
                return null;
            }

            var user = new UserModel()
            {
                Name = values[0].ToString(),
                Phone = values[1].ToString(),
                Email = values[2].ToString(),
            };
            return user;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
