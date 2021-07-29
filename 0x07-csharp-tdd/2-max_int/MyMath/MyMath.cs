using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    /// <summary>
    /// Contains Max method.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns the maximum value of a list of ints.
        /// </summary>
        public static int Max(List<int> nums)
        {
            try
            {
                return nums.Max();
            }
            catch (System.InvalidOperationException)
            {
                return 0;
            }
        }
    }
}
