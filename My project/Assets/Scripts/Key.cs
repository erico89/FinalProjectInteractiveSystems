using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject key;
    public GameObject enemy;

    void Update()
    {
        key.transform.position = transform.position;
    }
    
    /*
    private void OnTriggerEnter(Collider col)
    {
        key.transform.position = transform.position;
    }
    */
}
