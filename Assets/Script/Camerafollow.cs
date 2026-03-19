using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform target;                    //카메라가 따라갈 대상
    public Vector3 offset = new Vector3(0f, 12f, -8f);


    void LateUpdate()
    {
        if (target == null) return;

        transform.position = target.position + offset;
    }
}
