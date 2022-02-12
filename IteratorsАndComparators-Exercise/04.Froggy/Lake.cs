using System.Collections;
using System.Collections.Generic;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        public int[] Stones { get; set; }

        public Lake(int[] stones)
        {
            Stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Stones.Length; i += 2)
            {
                yield return Stones[i];
            }

            int index = Stones.Length % 2 == 0 ? Stones.Length - 1 : Stones.Length - 2;

            for (int j = index; j >= 0; j -= 2)
            {
                yield return Stones[j];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}