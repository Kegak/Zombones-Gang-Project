using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public GameObject target; // Player

    public float lerpVal = 1f;
    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(target.transform);

        /*transform.LookAt(
            Mathf.Lerp(
                this.transform.position, 
                target.transform, 
                Time.deltaTime * lerpVal));*/
    }
}
