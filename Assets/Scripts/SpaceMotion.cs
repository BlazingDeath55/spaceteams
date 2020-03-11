using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceMotion : MonoBehaviour
{

    public float game_duration; //in minutes
    float speed;
    Rigidbody myRb;

    // Start is called before the first frame update
    void Start()
    {
        speed = -700 / (game_duration * 60);
        myRb = GetComponent<Rigidbody>();
        myRb.velocity = new Vector3(0, 0, -speed);
    }

    // Update is called once per frame
    void Update()
    {
        myRb.velocity = new Vector3(0, 0, speed);
    }
}
