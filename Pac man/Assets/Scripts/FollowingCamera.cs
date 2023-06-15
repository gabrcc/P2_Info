using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    public Transform target;
    public float speed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 pos = target.position + offset;
        transform.position = pos;
    }
}
