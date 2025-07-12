using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier
{
    public class Test
    {
        int sum = 0;
        public void Method1(params int[] array)
        {
            foreach(var i in array){
                sum += i;
            }
        }
    }
}
