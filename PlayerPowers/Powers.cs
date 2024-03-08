using System;

namespace Powers
{
    [Flags]
    public enum PowerEnum
    {
        Fly = 1<<0,
        XRayVision = 1<<1,
        SuperStrength = 1<<2
    }
}