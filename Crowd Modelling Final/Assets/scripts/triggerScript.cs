using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour
{

    bool infected;
    float num;
    GameStateManager gsm;
    public string searcher = "Caution";

    private void Start()
    {
        GameObject gob;

        gob = GameObject.Find("GameState");

        gsm = gob.GetComponent<GameStateManager>();
    }

    private void Update()
    {

    }


    //Sneeze hitbox code 
    void OnTriggerEnter(Collider ent)
    {
        //counting infectious code

        if (ent.tag == searcher)
        {
            gsm.adjustCounter(1);

            Debug.Log("Infected, total infected: " + gsm.queryCounter());
            return;
        }



        /*Infection chance calculaiton
        num = Random.Range(0, 100);
        Debug.Log("Enter" + num);

        if (num < 60)
        {
            infected = true;
            return;
        }

        infected = false;
        */

    }

    void OnTriggerExit(Collider ext)
    {
        //Debug.Log("Exit" + infected);

    }

}