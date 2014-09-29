using System;

namespace GenericList
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface
    | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = true)]

    public class Version : System.Attribute
    {
        public int MajorVersion { get; private set; }
        public int MinorVersion { get; private set; }

        public Version(int majorVer, int minorVer)
        {
            this.MajorVersion = majorVer;
            this.MinorVersion = minorVer;
        }

        public override string ToString()
        {
            return this.MajorVersion + "." + this.MinorVersion;
        }
    }
}