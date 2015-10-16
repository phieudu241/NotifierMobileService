using System;

namespace NotifierMobile.Enums
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class EnumAttr : Attribute
    {
        public EnumAttr()
        {
        }
    }
}
