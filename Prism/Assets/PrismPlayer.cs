using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrismPlayer : MonoBehaviour
{
    //VARS
    private LineRenderer laserLine;



    [Header("Set in Inspector")]
    public float jumpheight = 10f;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody Prism = GetComponent<Rigidbody>();
        laserLine = GetComponent<LineRenderer>();
    }

    void shoot() 

    {
        RaycastHit hit;
        if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(transform.position,transform.forward,out hit)) { if (hit.collider.gameObject.tag == "Tagged") { Debug.DrawRay(transform.position, transform.forward, Color.green); print("Hit"); } }
        }
    }
        
    // Update is called once per frame
    // Update, check if either W a S or D is pressed
    void Update()
    {
        //allows for the ability to control the prism using the wasd keys  w is to jump
        Rigidbody Prism = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            Prism.AddForce(Vector3.left);
        if (Input.GetKey(KeyCode.D))
            Prism.AddForce(Vector3.right);
        if (Input.GetKey(KeyCode.S))
            Prism.AddForce(Vector3.down);
        if (Input.GetKey(KeyCode.W))
            Prism.AddForce(Vector3.up * jumpheight);

        //checks if the player shoots out a ray that reflects




    }
}
