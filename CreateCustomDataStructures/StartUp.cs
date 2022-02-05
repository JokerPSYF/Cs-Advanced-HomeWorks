using System;

namespace CreateCustomDataStructures
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            for (int i = 1; i < 50; i++)
            {
                list.Add(i);
            }
        }


    }
}
