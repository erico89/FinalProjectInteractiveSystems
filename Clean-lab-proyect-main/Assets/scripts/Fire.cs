using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public int isCurrentlyColliding;
    public GameObject wood;

    // Start is called before the first frame update
    void Start()
    {
        isCurrentlyColliding = -1;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Fire"))
        {
            isCurrentlyColliding = 0;
        }
    }

        // Update is called once per frame
    void Update()
    {
        if(isCurrentlyColliding == 0)
        {
            Destroy(wood.gameObject);
        }
    }
}
