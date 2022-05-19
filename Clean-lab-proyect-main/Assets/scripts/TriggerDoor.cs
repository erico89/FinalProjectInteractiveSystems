using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool openTrigger = false;
    private bool done = true;

    private void OnTriggerEnter(Collider other)
    { 
        if(other.CompareTag("Key"))
        {
            if (openTrigger && done) 
            {
                myDoor.Play("DoorOpen", 0, 0.0f);
                done = false;
                //gameObject.SetActive(false);
            }
        }
    } 
}
