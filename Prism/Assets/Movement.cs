using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float rotationSpeed = 2f;

    // Update is called once per frame
    void OnMouseDrag()
    {
        float ZaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;

        transform.Rotate(Vector3.right, ZaxisRotation);
        
    }
}
