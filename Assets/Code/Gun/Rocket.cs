using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour, Bullet
{
    public float hit { get; set; }
    public float radius { get; set; }
    public bool is_collision { get; set; }

    public float Speed { get; set; }
    Vector3 lastPos;
    public GameObject decal;

    void Start()
    {
        lastPos = transform.position;
    }

    void Update()
    {
      

    }


    public void Shot(float velocity)
    {
        transform.parent = null;
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().velocity = transform.forward * velocity;
    }

   
}
