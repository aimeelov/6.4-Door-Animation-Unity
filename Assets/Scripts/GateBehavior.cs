using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateBehavior : MonoBehaviour
{
    // OnTrigger is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.BroadcastMessage("OpenGate");
        }
    }

    // OnTrigger is called when the Collider other has stopped touching the trigger
    private void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            gameObject.BroadcastMessage("CloseGate");
        }
    }
}


