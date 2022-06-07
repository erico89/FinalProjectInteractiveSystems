using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAndGet : MonoBehaviour
{
    public GameObject key;
    public GameObject player;
    public GameObject FatherKey;
    public Transform guide;
    private bool active;
    private int collisionCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        active = false;
        key.GetComponent<Rigidbody>().useGravity = true; 
    }

    // Update is called once per frame
    void Update()
    {
        if(active == true){
            key.GetComponent<Rigidbody>().useGravity = false;
            key.GetComponent<Rigidbody>().isKinematic = true;
            key.transform.position = guide.transform.position;
            key.transform.rotation = guide.transform.rotation;
            key.transform.parent = player.transform;
        }
        if (collisionCount == 0){
            active = false;
            key.transform.parent = FatherKey.transform;
            key.transform.position = new Vector3(6,key.transform.position.y,5.5f);
        }
    }

    private void OnTriggerEnter(Collider other)
    { 
        if(other.CompareTag("Player1"))
        {
            active = true;
        }
        if(other.CompareTag("Sand"))
        {
            collisionCount++;
        }
        
    } 
    private void OnTriggerExit(Collider other)
    { 
        if(other.CompareTag("Sand"))
        {
            collisionCount--;
        }
    } 
}
