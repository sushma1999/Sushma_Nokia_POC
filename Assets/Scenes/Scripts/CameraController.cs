using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // To control camera

        public GameObject Player;
        private Vector3 offset;// offset to get the distance from the player object 
    void Start()
    {
        offset = transform.position;
    }
    private void LateUpdate()
    {
        //lets add the offset to follow the player movement
        transform.position = Player.transform.position + offset;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
