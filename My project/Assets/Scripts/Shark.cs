using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{
    public float runSpeed;
    private Collider myCollider;
    private Rigidbody myRigidbody;
    private SharkSpawner sharkSpawner;
    public float dropDestroyDelay;
    // Start is called before the first frame update

    void Start()
    {
        myCollider = GetComponent<Collider>();
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*runSpeed * Time.deltaTime);
    }

    public void SetSpawner(SharkSpawner spawner)
    {
        sharkSpawner = spawner;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SharkDropper"))
        {
            Drop();
        }
    }

    private void Drop()
    {
        myRigidbody.isKinematic = false;
        myCollider.isTrigger = false;
        Destroy(gameObject, dropDestroyDelay);
    }
}
