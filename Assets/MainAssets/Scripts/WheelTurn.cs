using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelTurn : MonoBehaviour
{
    public float maxTurnAngle = 10f; // Maximum turn angle in degrees

    private void Update()
    {
        float turnInput = Input.GetAxis("Horizontal"); // Input for left/right steering

        float turnAngle = maxTurnAngle * turnInput;

        Vector3 currentRotation = transform.localRotation.eulerAngles;
        currentRotation.y = turnAngle;
        transform.localRotation = Quaternion.Euler(currentRotation);
    }
}
