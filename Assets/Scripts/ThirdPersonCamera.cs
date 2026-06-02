using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;

    public float distance = 5f;
    public float height = 2f;
    public float sensitivity = 150f;

    float yaw = 0f;

    void LateUpdate()
    {
        if (target == null) return;

        yaw += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        Vector3 offset =
            Quaternion.Euler(0, yaw, 0) *
            new Vector3(0, height, -distance);

        transform.position =
            target.position + offset;

        transform.LookAt(
            target.position + Vector3.up * 1.5f
        );
    }
}