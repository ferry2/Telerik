using System;
using System.Runtime.InteropServices;

namespace OOP2
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Enum |
        AttributeTargets.Method, AllowMultiple = true)]
    public class VersionAttribute : Attribute
    {
        public int major { get; private set; }
        public int minor { get; private set; }
        public string version
        {
            get 
            {
                return string.Format("The version is {0}.{1}", major, minor);
            }
        }

        public VersionAttribute(int _major, int _minor)
        {
            this.major = _major;
            this.minor = _minor;
        }
    }
}
