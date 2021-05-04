using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherT : MonoBehaviour
{

    public float speed = 8.0f;
    public float directionValue = 1.0f;
    public float turnSpeed = 50.0f;
    public float turnValue = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * (speed * directionValue) * Time.deltaTime;
        transform.Rotate(Vector3.up * (turnSpeed * turnValue) * Time.deltaTime);
    }
}
