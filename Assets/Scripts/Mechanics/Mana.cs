using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana : MonoBehaviour
{
    public int maxMP = 1;

    public int currentMP = 1;

    public void Increment(int value)
    {
        currentMP = Mathf.Clamp(currentMP + value, 0, maxMP);
    }

    public void Decrement(int value)
    {
        currentMP = Mathf.Clamp(currentMP - value, 0, maxMP);
    }

}
