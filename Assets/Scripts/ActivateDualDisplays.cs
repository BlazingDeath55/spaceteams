using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDualDisplays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ActivateDisplays();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ActivateDisplays() {
        for (int i = 1; i < Display.displays.Length; i++) {
            Display.displays[i].Activate();
        }
    }
}
