using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotBall : MonoBehaviour
{

    public IAController ia;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            ia.move = 1;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball")
        {
            ia.move = 0;
        }
    }
}
