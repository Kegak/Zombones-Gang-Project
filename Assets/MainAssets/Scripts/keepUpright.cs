using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepUpright : MonoBehaviour
{
    [Header("This script doesn't work lol")]
    [Header("So DO NOT use this right now")]
    public float limitX = 15f;
    public float limitZ = 10f;
    //private static Quaternion rot = this.Transform.rotation;

    // Update is called once per frame
    void Update()
    {  
        // X is rotating OVER bounds
        if(transform.rotation.x > Mathf.Abs(limitX)) 
        {
            transform.rotation = Quaternion.Euler(Mathf.Abs(limitX), transform.rotation.y, transform.rotation.z);
        }
        // X is rotating UNDER bounds
        else if(transform.rotation.x < -Mathf.Abs(limitX))
        {
            transform.rotation = Quaternion.Euler(-Mathf.Abs(limitX), transform.rotation.y, transform.rotation.z);
        }

        // Z is rotating OVER bounds
        if(transform.rotation.z > Mathf.Abs(limitZ)) 
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, Mathf.Abs(limitZ));
        }
        // Z is rotating UNDER bounds
        else if(transform.rotation.z < -Mathf.Abs(limitZ))
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, -Mathf.Abs(limitZ));
        }

    }
}
