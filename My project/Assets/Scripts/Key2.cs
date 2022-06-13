using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key2 : MonoBehaviour
{
    public GameObject key2;
    public GameObject key3;
    public int isCurrentlyColliding;

    void Start()
    {
        isCurrentlyColliding = -1;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("key2"))
        {
            isCurrentlyColliding = 0;
        }
        else if (col.CompareTag("Respawn2"))
        {
            isCurrentlyColliding = 1;
        }
        else if (col.CompareTag("Respawn"))
        {
            isCurrentlyColliding = 1;
        }
        else if (col.CompareTag("base2"))
        {
            isCurrentlyColliding = 2;
        }
    }

    void Update()
    {
        if (isCurrentlyColliding == 0)
        {
            key2.transform.position = transform.position;
        }
        else if (isCurrentlyColliding == 1)
        {
            key2.transform.position = new Vector3(10, 1, 36);
        }
        else if (isCurrentlyColliding == 2)
        {
            key2.SetActive(false);
            key3.SetActive(true);
            
        }
    }
}
