using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static List<int> Map(this int[] numbers, Func<int, int> todo)
        {
            List<int> output = new List<int>();
            foreach (int i in numbers)
            {
                output.Add(todo(i));
            }
            return output;
            //throw new NotImplementedException();
        }
    }
}
