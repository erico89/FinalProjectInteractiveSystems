using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject key;
    bool isCurrentlyColliding2;

    void OnTriggerEnter(Collider col)
    {
        isCurrentlyColliding2 = true;
    }

    void Update()
    {
        if (isCurrentlyColliding2)
        {
            key.transform.position = transform.TransformPoint(90, -1, 20);
        }
    }
}
