using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject target;
    public float damping = 20;
    public bool withDamping = true;

    Vector3 offset;

    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    void LateUpdate()
    {
        if (withDamping)
        {
            WithDamping();
        }
        else
        {
            WithoutDamping();
        }
    }

    void WithDamping()
    {
        float currentAngle = transform.eulerAngles.y;
        float desiredAngle = target.transform.eulerAngles.y;

        float angle = Mathf.Lerp(currentAngle, desiredAngle, Time.deltaTime * damping);

        Quaternion rotation = Quaternion.Euler(0, angle, 0);
        transform.position = target.transform.position + (rotation * offset);

        transform.LookAt(target.transform);
    }

    void WithoutDamping()
    {
     
        float desiredAngle = target.transform.eulerAngles.y;
        
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = target.transform.position + (rotation * offset);

        transform.LookAt(target.transform);
    }
}
