using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
 


public class AgentAI : MonoBehaviour
{
    public GameObject[] Agents;
    public GameObject goal;
    NavMeshAgent agent;
    //GameObject[] Agents;
    public int infectionRange;
    private GameObject[] transfer;
    private GameObject[] directions;
    public Material newMat;
    private int tempSpd;
    //public int temp;
    

    // Start is called before the first frame update
    void Start()
    {
        GameObject gsm = GameObject.Find("GameState");
        GameStateManager gt = gsm.GetComponent<GameStateManager>();

        directions = gt.waypoints;
        //transfer = gt.Agents;
        //temp = transfer.Length;

        tempSpd = gt.speedRange;


        agent = this.GetComponent<NavMeshAgent>();

        agent.speed = Random.Range(1, tempSpd);

        //agent.SetDestination(goal.transform.position);

        foreach ( GameObject k in directions)
        {
            int temp = Random.Range(0, directions.Length);

            agent.SetDestination(directions[temp].transform.position);
        }


        /*agent priority change
        int jeff = 30;

        agent.avoidancePriority = jeff;

        Debug.Log(agent.avoidancePriority);
        */

        //infectious simulation

        /*
        if (Agents.Length == 0)
        {
            Agents = GameObject.FindGameObjectsWithTag("healthy");
            Debug.Log("Agents: " + Agents.Length);

            Debug.Log("Agent 1: " + Agents[0]);
        }
        */

        
    }


    // Update is called once per frame
    void Update()
    {

        Agents = GameObject.FindGameObjectsWithTag("healthy");
        //if Agent infected, check to infect others
        if (this.gameObject.tag == "infected")
        {
            infectionCheck();
            //temp--;
        }
    }

    void infectionCheck()
    {
        foreach (GameObject j in Agents)
        {
            if (j.tag == "healthy")
            {
                //checks distance between compared agents
                float temp = Vector3.Distance(transform.position, j.transform.position);

                if (temp < infectionRange)
                {
                    j.transform.tag = "Caution";

                    //Material newMat = Resources.Load("InfectedM", typeof(Material)) as Material;
                    j.GetComponent<Renderer>().material = newMat;

                }
            }



        }
        //Debug.Log("test");
    }



}
