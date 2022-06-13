    using UnityEngine;
    using System.Collections;
    public class TRACER1 : MonoBehaviour
    {
        public GameObject DotPrefab;
        public GameObject Player;
        Vector3 lastDotPosition;
        bool lastPointExists;
        int i = 0;
        void Start()
        {
            lastPointExists = true;
        }
        void Update()
        {
            Vector3 newDotPosition = Player.transform.position;
            newDotPosition.y -= 4.7f;
            GameObject dot =(GameObject) Instantiate(DotPrefab, newDotPosition, Quaternion.identity);
            GameObject.Destroy(dot,1.5f);
            // MakeADot(newDotPosition);
        }
        // void MakeADot(Vector3 newDotPosition)
        // {
        //     GameObject dot =(GameObject) Instantiate(DotPrefab, newDotPosition, Quaternion.identity); //use random identity to make dots looks more different
        //     // if (lastPointExists)
        //     // {
        //     //     GameObject colliderKeeper = new GameObject("collider");
        //     //     BoxCollider bc = colliderKeeper.AddComponent<BoxCollider>();
        //     //     colliderKeeper.transform.position = Vector3.Lerp(newDotPosition, lastDotPosition, 0.5f);
        //     //     colliderKeeper.transform.LookAt(newDotPosition);
        //     //     bc.size = new Vector3(0.1f, 0.1f, Vector3.Distance(newDotPosition, lastDotPosition));
        //     //     Destroy(colliderKeeper);
        //     // }
        //     //GameObject.DestroyImmediate(dot);
        //     lastPointExists = true;
        // }
    }
