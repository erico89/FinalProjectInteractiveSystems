using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire2 : MonoBehaviour
{

    public int isCurrentlyColliding;
    public GameObject wood;
    public GameObject hay;
    public GameObject fire;
    public GameObject smoke;
    public bool fire_bool;

    // Start is called before the first frame update
    void Start()
    {
        isCurrentlyColliding = -1;
        fire_bool = true;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Fire2"))
        {
            if (fire_bool == true)
            {
                fire_bool = false;
                Instantiate(fire);
                Instantiate(smoke);
            }
            isCurrentlyColliding = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isCurrentlyColliding == 0)
        {
            Destroy(hay.gameObject);
            Destroy(wood.gameObject);
        }
    }
}
