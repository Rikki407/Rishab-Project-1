using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlip : MonoBehaviour
{
    public Light Dayligh;
    public Light Nightlight;
    float xVal;
    float yVal;
    float zVal;
    bool flipped;
    bool reset;
    int mode;
    public GameObject ClassCube;
    int upsideDown;
    
    void Start()
    {
        InvokeRepeating("Update",0f,10f);
        zVal = 0f;
        mode = 1;
        Nightlight.enabled = false;
        if (Vector3.Dot(ClassCube.transform.up, Vector3.down) > 0) {
            upsideDown = 1;
        }
    }

    void Update()
    {    
        zVal = ClassCube.transform.localEulerAngles.z;
        if (Vector3.Dot(ClassCube.transform.up, Vector3.down) > 0) {
            upsideDown = 1;
        }
        if ((Vector3.Dot(ClassCube.transform.up, Vector3.down) < 0) & upsideDown == 1){
            upsideDown = 0;
            mode = mode*-1;
        }
        if (mode == 1)
        {
            Dayligh.enabled = true;
            Nightlight.enabled = false;
        }
        else if (mode == -1)
        {
            Dayligh.enabled = false;
            Nightlight.enabled = true;
        }
    }
}
