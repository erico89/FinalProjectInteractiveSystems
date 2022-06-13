using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key3 : MonoBehaviour
{
    public GameObject key;
    public int isCurrentlyColliding;

    void Start()
    {
        isCurrentlyColliding = -1;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("key3"))
        {
            isCurrentlyColliding = 0;
        }
        else if (col.CompareTag("Respawn3"))
        {
            isCurrentlyColliding = 1;
        }
        else if (col.CompareTag("Respawn2"))
        {
            isCurrentlyColliding = 1;
        }
    }

    void Update()
    {
        if (isCurrentlyColliding == 0)
        {
            key.transform.position = transform.position;
        }
        else if (isCurrentlyColliding == 1)
        {
            key.transform.position = new Vector3(10, 1, 69);
        }
    }
}
