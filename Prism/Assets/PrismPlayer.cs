using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrismPlayer : MonoBehaviour
{
    //VARS

    public float jumpheight = 10f;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody Prism = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    // Update, check if either W a S or D is pressed
    void Update()
    {
        Rigidbody Prism = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            Prism.AddForce(Vector3.left);
        if (Input.GetKey(KeyCode.D))
            Prism.AddForce(Vector3.right);
        if (Input.GetKey(KeyCode.S))
            Prism.AddForce(Vector3.down);
        if (Input.GetKey(KeyCode.W))
            Prism.AddForce(Vector3.up * jumpheight);

    }
}
