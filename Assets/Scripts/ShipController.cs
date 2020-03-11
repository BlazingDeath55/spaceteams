using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    // Start is called before the first frame update
    public int boundX, boundY;
    public int maxRoationDeg = 15;
    public int maxVerticalRotation = 10;
    public float rotationSpeed = 0.05f;
    public int forceMultiplier = 2;
    public int responseFactor = 2; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector3 inputV = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0) * forceMultiplier;

        if (Mathf.Sign(inputV.x) == -Mathf.Sign(transform.GetComponent<Rigidbody>().velocity.x) && Mathf.Abs(inputV.x) >= 0.5)
        {
           inputV.x *= responseFactor;

        }

        if (Mathf.Abs(inputV.x) <= 0.5)
        {
            inputV.x = -transform.GetComponent<Rigidbody>().velocity.x;
        }
        
        if(Mathf.Abs(inputV.y) <= 0.5) {
            inputV.y = -transform.GetComponent<Rigidbody>().velocity.y;
        }

        

        transform.GetComponent<Rigidbody>().AddForce(inputV);


        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -boundX, boundX), Mathf.Clamp(transform.position.y, -boundY, boundY), 0);

        Vector3 rotation = new Vector3(Mathf.Lerp(0, maxVerticalRotation, Mathf.Abs(transform.GetComponent<Rigidbody>().velocity.y) * rotationSpeed), 0, Mathf.Lerp(0, maxRoationDeg, Mathf.Abs(transform.GetComponent<Rigidbody>().velocity.x)*rotationSpeed));

        if (transform.GetComponent<Rigidbody>().velocity.x > 0) {
            rotation.z = -rotation.z;
        }

        if (transform.GetComponent<Rigidbody>().velocity.y > 0) {
            rotation.x = -rotation.x;
        }


        //Debug.Log(rotation);


        transform.rotation = Quaternion.Euler(rotation);
    
    }

    

    
}
