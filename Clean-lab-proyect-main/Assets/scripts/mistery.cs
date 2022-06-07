using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mistery : MonoBehaviour
{

    public int isCurrentlyColliding;
    public GameObject good;
    public GameObject bad;

    void Start()
    {
        isCurrentlyColliding = -1;
        bad.SetActive(false);
        good.SetActive(false);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Respawn2"))
        {
            isCurrentlyColliding = 0;
        }
        else if (col.CompareTag("good"))
        {
            isCurrentlyColliding = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isCurrentlyColliding == 0)
        {
            bad.SetActive(true);
        }
        else if(isCurrentlyColliding == 1)
        {
            good.SetActive(true);
        }
    }
}
