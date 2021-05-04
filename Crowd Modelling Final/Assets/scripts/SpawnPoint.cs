using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;

public class SpawnPoint : MonoBehaviour
{

    public GameObject Agent;
    public int iniTarget = 10;
    GameObject[] Agents;
    public float chance = 10.0f;
    private float range = 100;
    public float timeDelay = 1.0f;
    public int secTarg;
    public float time;
    public Material newMat;
    

    //public int target = 10;
    // Start is called before the first frame update
    void Start()
    {

        secTarg = iniTarget;
        time = timeDelay;

    }

    // Update is called once per frame
    void Update()
    {

        
            if (time > 0)
            {
                time -= Time.deltaTime;
                //Debug.Log(time);
            }

            else if (time < 0 && secTarg > 0)
            {
                spawnCycle();
                secTarg--;
                time = timeDelay;
            }
        
            
        /*
        if (time > 0)
        {
            time -= Time.deltaTime;
            Debug.Log(time);
        }

        else if (time < 0 && secTarg > 0)
        {
            spawnCycle();
        }
        */

    }

    void spawnCycle()
    {

        GameObject clone;

        clone = Instantiate(Agent, transform.position, transform.rotation);

        if (Random.Range(0, range) <= chance)
        {
            clone.transform.tag = "infected";

            //Material newMat = Resources.Load("InfectedM2", typeof(Material)) as Material;
            clone.GetComponent<Renderer>().material = newMat;
         
        }

        

        /*
        GameObject clone;

        for (int target = iniTarget; target > 0; target--)
        {
            clone = Instantiate(Agent, transform.position, transform.rotation);
            //GameObject goal;

            if (Random.Range(0, range) <= chance)
            {
                clone.transform.tag = "infected";

                Material newMat = Resources.Load("InfectedM2", typeof(Material)) as Material;
                clone.GetComponent<Renderer>().material = newMat;
            }

            secTarg--;

            //goal = GameObject.Find("goal2").GetComponent
            //clone.GetComponent<AgentAI>().goal = GameObject.Find("goal2");
        }
        */
    }
    
}
