using System;
using Avalonia.Media;
using RefactorMe.Common;

namespace RefactorMe
{
    class Painter
    {
        public static int[] GetFirstEvenNumbers(int count)
        {
            if (count <= 0)
            {
                return new int[0];
            }
            int[] array;
            array = new int[count];
            array[0] = 2;
            for (var i = 1; i < array.Length; i++)
            {
                array[i] = array[i - 1] + 2;
            }
            return array;
        }
    }
}
