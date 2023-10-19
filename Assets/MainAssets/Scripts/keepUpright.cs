using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepUpright : MonoBehaviour
{
    public float limitX = 15f;
    public float upperLimitX = 345f;
    public float limitZ = 10f;
    public float upperLimitZ = 350f;
    void Update()
    {  

        if(Mathf.Abs(transform.localEulerAngles.x) > limitX && Mathf.Abs(transform.localEulerAngles.x) < upperLimitX) 
        {
            transform.rotation = Quaternion.Euler(0, transform.rotation.y, transform.rotation.z);
            Debug.Log("Adjusted! " + transform.rotation);
        }

        if(Mathf.Abs(transform.localEulerAngles.z) > limitZ && Mathf.Abs(transform.localEulerAngles.z) < upperLimitZ) 
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0);
            Debug.Log("Adjusted! " + transform.rotation);
        }
    }
}
