using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaser : MonoBehaviour
{
    public Material material;
    Laser beam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(GameObject.Find("Laser"));
        beam = new Laser(gameObject.transform.position, gameObject.transform.right, material);
    }
}
