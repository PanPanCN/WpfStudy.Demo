using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;

namespace FormValidate.Demo
{
    public class ValidateModelBase : ObservableObject, IDataErrorInfo
    {
        public ValidateModelBase() { }

        #region 属性 
        /// <summary>
        /// 表当验证错误集合
        /// </summary>
        private readonly Dictionary<string, string> _dataErrors = new Dictionary<string, string>();

        /// <summary>
        /// 是否验证通过
        /// </summary>
        public bool IsValidated => _dataErrors == null || _dataErrors.Count <= 0;

        #endregion

        public string this[string columnName]
        {
            get
            {
                var vc = new ValidationContext(this, null, null)
                {
                    MemberName = columnName
                };
                var res = new List<ValidationResult>();
                var propertyInfo = GetType().GetProperty(columnName);
                var result = Validator.TryValidateProperty(propertyInfo?.GetValue(this, null), vc, res);
                if (res.Count > 0)
                {
                    AddDic(_dataErrors, vc.MemberName);
                    return string.Join(Environment.NewLine, res.Select(m => m.ErrorMessage).ToArray());
                }
                RemoveDic(_dataErrors, vc.MemberName);
                return null;
            }
        }

        public string Error => null;


        #region 附属方法

        /// <summary>
        /// 移除字典
        /// </summary>
        private static void RemoveDic(IDictionary<string, string> dics, string dicKey)
        {
            dics.Remove(dicKey);
        }

        /// <summary>
        /// 添加字典
        /// </summary>
        private static void AddDic(IDictionary<string, string> dics, string dicKey)
        {
            if (!dics.ContainsKey(dicKey))
                dics.Add(dicKey, string.Empty);
        }
        #endregion
    }
}
