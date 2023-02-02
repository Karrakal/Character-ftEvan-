using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;
    public float distance = 5.0f;
    public float height = 2.0f;

    void LateUpdate()
    {
        transform.position = target.position + (-target.forward * distance) + (Vector3.up * height);
        transform.LookAt(target);
    }
}
