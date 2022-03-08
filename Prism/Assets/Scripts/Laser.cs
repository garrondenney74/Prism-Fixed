using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    //Variables
    Vector3 pos, dir;

    GameObject laserObj;
    LineRenderer laser;
    List<Vector3> laserIndices = new List<Vector3>();

    public LaserBeam(Vector3 pos, Vector3 dir, Material material)
    {
        this.laser =  new LineRenderer();
        this.laserObj = new GameObject();
        this laserObj.name = ("Laser");
        this.pos = pos;
        this.dir = dir;

        this.laser = this.laserOBj.AddComponent(typeof(LineRenderer)) as LineRenderer;
        this.laser.startWidth = 0.1f;
        this.laser.endWidth = 0.1f;
        this.laser.material = material;
        this.laser.startColor = Color.green;
        this.laser.endColor = Color.green;
    }
}
