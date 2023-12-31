using UnityEngine;

public class MouseAimCamera : MonoBehaviour
{
    public GameObject target;
    public float rotateSpeed = 5;
    //public float lerpStrength = 20;

    Vector3 offset;
    void Start()
    {
        offset = transform.position - target.transform.position;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    void LateUpdate()
    {
        //Mouse turns the player
        //float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        //target.transform.Rotate(0, horizontal, 0);

        float desiredAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = target.transform.position + (rotation * offset);

        transform.LookAt(target.transform);
    }
}
