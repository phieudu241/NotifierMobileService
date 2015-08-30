using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
