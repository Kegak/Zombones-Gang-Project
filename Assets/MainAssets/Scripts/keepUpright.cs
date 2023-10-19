using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepUpright : MonoBehaviour
{
    private float limitX = 30f;
    private float upperLimitX = 330f;
    private float limitZ = 10;
    private float upperLimitZ = 350f;
    private float dampening = 20;
    void Update()
    {  
        if(Mathf.Abs(transform.localEulerAngles.x) > limitX && Mathf.Abs(transform.localEulerAngles.x) < upperLimitX) 
        {
            Debug.Log((transform.localEulerAngles.x, transform.localEulerAngles.z));
            if(transform.localEulerAngles.x > 180)
            {
                float target = 360f;
                float angle = Mathf.Lerp(transform.localEulerAngles.x, target, Time.deltaTime * dampening);
                transform.eulerAngles = new Vector3(angle, transform.localEulerAngles.y, transform.localEulerAngles.z);
            }
            else
            {
                float target = 0;
                float angle = Mathf.Lerp(transform.localEulerAngles.x, target, Time.deltaTime * dampening);
                transform.eulerAngles = new Vector3(angle, transform.localEulerAngles.y, transform.localEulerAngles.z);
            }
            Debug.Log((transform.localEulerAngles.x, transform.localEulerAngles.z));
        }

        if(Mathf.Abs(transform.localEulerAngles.z) > limitZ && Mathf.Abs(transform.localEulerAngles.z) < upperLimitZ) 
        {
            Debug.Log((transform.localEulerAngles.x, transform.localEulerAngles.z));
            if(transform.localEulerAngles.z > 180)
            {
                float target = 360f;
                float angle = Mathf.Lerp(transform.localEulerAngles.z, target, Time.deltaTime * dampening);
                transform.eulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, angle);
            }
            else
            {
                float target = 0f;
                float angle = Mathf.Lerp(transform.localEulerAngles.z, target, Time.deltaTime * dampening);
                transform.eulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, angle);;
            }
            Debug.Log((transform.localEulerAngles.x, transform.localEulerAngles.z));
        }
    }
}
