using System;

namespace ChadRosenthal.Application.Services
{
    public class TestInterface : ITestInterface
    {
        public string Add()
        {
            return "this is from the interface";
        }
    }
}
