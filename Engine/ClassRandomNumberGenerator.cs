using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public static class ClassRandomNumberGenerator
    {
        private static Random _generator = new Random();

        public static int NumberBetween(int minVal, int maxVal)
        {
            return _generator.Next(minVal, maxVal + 1);
        }
    }
}
