using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // A static field accessible by code anywhere
    GameManager gm = GameManager.GM;
    void OnTriggerEnter( Collider other ) 
    {
        // When the trigger is hit by something
        // Check to see if it's a Projectile
        if (other.gameObject.tag == "prismShot") 
        {
            gm.nextLevel = true;
        }
}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}