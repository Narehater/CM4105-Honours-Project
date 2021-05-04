using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameStateManager : MonoBehaviour
{
    private int counter;
    //private GameObject waypoint;
    //public GameObject[] Agents;
    public int speedRange = 4;
    public GameObject[] waypoints;


    
    private void Start()
    {
        waypoints = GameObject.FindGameObjectsWithTag("waypoints");

        //Agents = GameObject.FindGameObjectsWithTag("healthy");
        //Debug.Log("Agents: " + Agents.Length);



    }


    public void adjustCounter(int val)
    {
        counter += val;
    }
    public int queryCounter()
    {
        return counter;
    }
    /*public void chooseWay(GameObject way)
    {
        way = waypoint;
    }*/

}