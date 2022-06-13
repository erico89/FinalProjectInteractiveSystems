using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingScene : MonoBehaviour
{
    public int numeroEscena;
    public GameObject keyFalling;
    private int counter;

    void Start()
    {
        counter = 0;
    }

    void Update()
    {
        if(counter == 2){
            SceneManager.LoadScene(numeroEscena);
        }
    }

    private void OnTriggerEnter(Collider other)
    { 
        if(other.CompareTag("Player1"))
        {
            counter++; 
        }

        if(other.CompareTag("Player2"))
        {
            counter++; 
        }
    } 

    private void OnTriggerExit(Collider other)
    { 
        if(other.CompareTag("Player1"))
        {
            counter--; 
        }

        if(other.CompareTag("Player2"))
        {
            counter--; 
        }
    } 
}
