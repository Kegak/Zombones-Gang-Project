using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WheelSpin : MonoBehaviour
{
    public float maxRotationSpeed = 500f;
    
    // Update is called once per frame
    void Update()
    {
        float rot_per_second = maxRotationSpeed * Input.GetAxis("Vertical"); 

        transform.Rotate(Vector3.right, rot_per_second * Time.deltaTime);
    }
}
