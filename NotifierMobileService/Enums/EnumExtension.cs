using System;
using System.Reflection;

namespace NotifierMobile.Enums
{
    public static class EnumExtension
    {
        public static EnumAttr GetAttr(this Enum value)
        {
            Type type = value.GetType();
            FieldInfo fieldInfo = type.GetField(value.ToString());
            var atts = (EnumAttr[])fieldInfo.GetCustomAttributes(typeof(EnumAttr), false);
            return atts.Length > 0 ? atts[0] : null;
        }
    }
}
