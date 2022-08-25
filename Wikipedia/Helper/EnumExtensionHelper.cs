using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Wikipedia.WikiSearch.Common;

namespace Wikipedia.Helper
{
    internal static class EnumExtensionHelper
    {
        /// <summary>
        /// 获取枚举类型的String值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static string GetStringValue(this Enum value)
        {
            // 获取类型
            Type type = value.GetType();

            // 获取类型属性信息
            FieldInfo fieldInfo = type.GetField(value.ToString());

            // 从自定义属性中查找指定类型属性
            StringValueAttribute[] attr = fieldInfo.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];

            if (attr.Length == 0)
                throw new InvalidOperationException("Unable to find StringValue attribute on " + type.Name);

            // 如果匹配了就返回第一个属性值
            return attr[0].StringValue;
        }
    }
}
