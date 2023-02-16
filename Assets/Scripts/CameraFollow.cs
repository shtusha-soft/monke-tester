using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate runs a bit after Update
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }


}
