    using System.Collections;  
    using System.Collections.Generic;  
    using UnityEngine;  
      
    public class Movement2 : MonoBehaviour  
    {  
         
        // Start is called before the first frame update  
        void Start()  
        {  
              
        }  
      
        // Update is called once per frame  
        void Update()  
        {  
            if (Input.GetKey(KeyCode.F))  
            {  
                transform.Translate(-0.1f, 0f, 0f);  
            }  
            if (Input.GetKey(KeyCode.H))  
            {  
                transform.Translate(0.1f, 0f, 0f);  
            }  
            if (Input.GetKey(KeyCode.G))  
            {  
                transform.Translate(0.0f, 0f, -0.1f);  
            }  
            if (Input.GetKey(KeyCode.T))  
            {  
                transform.Translate(0.0f, 0f, 0.1f);  
            }  
        }  
    } 