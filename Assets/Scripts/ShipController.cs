using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    // Start is called before the first frame update
    public int boundX, boundY;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector3 inputV = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);

        transform.position += inputV;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -boundX, boundX), Mathf.Clamp(transform.position.y, -boundY, boundY), 0);
     
    
    }

    

    
}
