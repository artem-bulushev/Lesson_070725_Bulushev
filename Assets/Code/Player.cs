using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code
{
    public class Player
    {
        private void Move()
        {
            int add = Add(a: 5, b: 9);
            Debug.LogError(message: Add(a: 7, b: 9));
        }

        private int Add(ulong a, ulong b)
        {
            return (int)(a + b);
        }

    }
}
