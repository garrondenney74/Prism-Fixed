







using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(LineRenderer))]

public class RaycastReflection : MonoBehaviour
{
    
    public int reflections;
    GameManager gm = GameManager.GM;
    public float maxLength;

    private LineRenderer lineRenderer;
    private Ray ray;
    private Ray ray2;
    private RaycastHit hit;
    private Vector3 direction;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(transform.position, transform.forward);
         
        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);
        float remainingLength = maxLength;

        for (int i = 0; i < reflections; i++)
        {
                if(Physics.Raycast(ray.origin, ray.direction, out hit, remainingLength))
                {
                        lineRenderer.positionCount += 1;
                        lineRenderer.SetPosition(lineRenderer.positionCount -1, hit.point);  
                        remainingLength -= Vector3.Distance(ray.origin, hit.point);

                    if(hit.collider.tag == "Up")
                    {
                        ray.direction = Vector3.up;
                        ray = new Ray(hit.point, ray.direction);
                        if(hit.collider.tag != "Up")
                            break;
                    }
                    if(hit.collider.tag == "Down")
                    {
                        ray.direction = Vector3.down;
                        ray = new Ray(hit.point, ray.direction);
                        if(hit.collider.tag != "Down")
                            break;
                    }
                    if(hit.collider.tag == "Mirror")
                    {
                        ray = new Ray(hit.point, Vector3.Reflect(ray.direction, hit.normal));
                        if(hit.collider.tag != "Mirror")
                            break;
                    }
                    if(hit.collider.tag == "Left")
                    {
                        ray.direction = Vector3.left;
                        ray = new Ray(hit.point, ray.direction);
                        if(hit.collider.tag != "Left")
                            break;
                    }
                    if(hit.collider.tag == "Right")
                    {
                        ray.direction = Vector3.right;
                        ray = new Ray(hit.point, ray.direction);
                        if(hit.collider.tag != "Right")
                            break;
                    }
                    if(hit.collider.isTrigger)
                    {
                        gm.nextLevel = true;
                    }

                }
                else
                {
                    lineRenderer.positionCount += 1;
                    lineRenderer.SetPosition(lineRenderer.positionCount - 1, ray.origin + ray.direction * remainingLength);
                }
        }
    }
}
