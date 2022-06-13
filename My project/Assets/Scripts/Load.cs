using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    private int count;
    public int numeroEscena;

    void Start()
    {
        count = 0;
    }

    private void OnTriggerEnter(Collider other)
    { 
        if(other.CompareTag("Player2"))
        {
            count = 1;
        }
    } 

    public void LoadNewScene()
    {
        if(count == 1){
            SceneManager.LoadScene(numeroEscena);
        }
    }
}
