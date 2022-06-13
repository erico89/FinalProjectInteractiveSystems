using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice : MonoBehaviour
{
    public GameObject lava;
    public GameObject ice_;
    private bool ice_bool;
    public int isCurrentlyColliding;

    void Start()
    {
        isCurrentlyColliding = 1;
        ice_bool = true;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("platform"))
        {
            if(ice_bool = true)
            {
                ice_bool = false;
                Instantiate(ice_);
            }
            isCurrentlyColliding = 0;
        }
    }

    void Update()
    {
        if (isCurrentlyColliding == 0)
        {
            lava.SetActive(false);
        }
        else if (isCurrentlyColliding == 1)
        {
            lava.SetActive(true);
        }
    }
}
