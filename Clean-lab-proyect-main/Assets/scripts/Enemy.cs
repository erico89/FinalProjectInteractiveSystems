using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject key;

    private void OnTriggerEnter(Collider col)
    {
        //key.transform.position = transform.TransformPoint(90, -1, 20);
        key.transform.position = transform.TransformPoint(0, 0, 0);
    }
}
