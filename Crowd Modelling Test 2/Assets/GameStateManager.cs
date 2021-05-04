using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameStateManager : MonoBehaviour
{
    private int counter;
    public void adjustCounter(int val)
    {
        counter += val;
    }
    public int queryCounter()
    {
        return counter;
    }
}