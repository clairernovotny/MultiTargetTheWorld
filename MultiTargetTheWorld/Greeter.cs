using System;
using MultiTargetTheWorld.Platforms;

namespace MultiTargetTheWorld
{
    public class Greeter
    {
        public string GetHello()
        {
            return PlatformGreeting.Hello();
        }
    }
}
