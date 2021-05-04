using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputScript : MonoBehaviour
{

    public GameObject hitbox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.Space))
        {

            //Debug.Log("2");

            GameObject clone;


            clone = Instantiate(hitbox, transform.position, transform.rotation);

        }
    }
}
