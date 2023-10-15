using UnityEngine;

public class PlayerCubeScript : MonoBehaviour
{
    public float moveSpeed = 10;
    public float turnSpeed = 60;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }
}
