using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    //public Rigidbody2D platform;
    public Transform platform;
    public bool isMovingVertically;
    public float speed;
    public float range;
    // Update is called once per frame
    void Update()
    {
        if (isMovingVertically == false)
        {
            platform.position = new Vector3(platform.position.x + speed, platform.position.y, platform.position.z);   
        }
    }
}
