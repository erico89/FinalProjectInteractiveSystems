using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PickAndGet : MonoBehaviour
{
    public GameObject key;
    public GameObject player;
    public GameObject FatherKey;
    public Transform guide;
    public GameObject keyFalling;
    private bool active;
    private bool sharkDetector;
    public int cutre;
    private int count;
    private int hielolokopasado2;
    private int hielolokopasado;
    private int hieloloko;
    private int collisionCount = 0;
    private Vector3 respawn;
    // Start is called before the first frame update
    void Start()
    {
        active = false;
        sharkDetector = false;
        hieloloko = 0;
        count = 0;
        hielolokopasado = hieloloko;
        hielolokopasado2 = hielolokopasado; 
        key.GetComponent<Rigidbody>().useGravity = true;
        respawn =  new Vector3(6,key.transform.position.y,5.5f);
    }

    // Update is called once per frame
    void Update()
    {

        if(active == true){
            key.GetComponent<Rigidbody>().useGravity = false;
            key.GetComponent<Rigidbody>().isKinematic = true;
            key.transform.position = guide.transform.position;
            key.transform.rotation = guide.transform.rotation;
            key.transform.parent = player.transform;
        }
        if ((collisionCount == 0 && (hieloloko == hielolokopasado2)) || sharkDetector == true){
            active = false;
            sharkDetector = false;
            key.transform.parent = FatherKey.transform;
            key.transform.position = respawn;
            Instantiate(keyFalling);
        }
        //Debug.Log(hieloloko + hielolokopasado + hielolokopasado2);
        count++;
        if (count % cutre == 0){
            hielolokopasado2 = hielolokopasado;
            hielolokopasado = hieloloko;
        }

    }

    private void OnTriggerEnter(Collider other)
    { 
        if(other.CompareTag("Player1"))
        {
            active = true;
        }
        if(other.CompareTag("Sand"))
        {
            collisionCount++;
        }
        if(other.CompareTag("Shark")){
            sharkDetector = true;
        }
        if(other.CompareTag("Flag")){
            respawn = new Vector3(49.4f,key.transform.position.y,45.5f);
        }
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Ice"))
        {
            hieloloko++;
        }
    }  
    private void OnTriggerExit(Collider other)
    { 
        if(other.CompareTag("Sand"))
        {
            collisionCount--;
        }
    }
    // private IEnumerator ExecuteAfterTime(float time)
    // {
    //     yield return new WaitForSeconds(time);
    //     if(collisionCount>0){collisionCount--;}
    // } 
}
