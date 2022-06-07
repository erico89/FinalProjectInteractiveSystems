using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key1 : MonoBehaviour
{
    public GameObject key;
    public GameObject key2;
    public GameObject key3;
    public GameObject concrete;
    public int isCurrentlyColliding;

    void Start()
    {
        isCurrentlyColliding = -1;
        key2.SetActive(false);
        key3.SetActive(false);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Key"))
        {
            isCurrentlyColliding = 0;
        }
        else if(col.CompareTag("Respawn"))
        {
            isCurrentlyColliding = 1;
        }
        else if (col.CompareTag("explosion"))
        {
            isCurrentlyColliding = 2;
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
            key.transform.position = new Vector3(90, 1, 23);
        }
        else if (isCurrentlyColliding == 2)
        {
            key.SetActive(false);
            key2.SetActive(true);
            Destroy(concrete.gameObject);
        }
    }
}
