using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float velocityUpdate = 10;
    public Vector3 OffSet = new Vector3(0, 0, -10);
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + OffSet, velocityUpdate * Time.deltaTime);
    }
}
