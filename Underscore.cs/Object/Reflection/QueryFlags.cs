using System;

namespace Underscore.Object.Reflection
{
    //can add more options here as needed
    [Flags]
    public enum QueryFlags : uint
    {
        Equal = 0x0,
        Like = 0x1,
    }
}