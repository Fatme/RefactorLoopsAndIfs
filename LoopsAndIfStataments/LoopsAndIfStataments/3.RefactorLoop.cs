using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoopsAndIfStataments
{
    class RefactorLoop
    {
        public static void Main()
        {
            int[] array = new int[100];
            int expectedValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        i = 666;
                    }
                }
            }
            int searchedNumber = 0;
            if (searchedNumber == 666)
            {
                Console.WriteLine("Value Found");
            }

        }
    }
}
