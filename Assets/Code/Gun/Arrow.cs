using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour, Bullet
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
      //  transform.Translate(Vector3.forward * Speed * Time.deltaTime);


    }

     public Arrow()
        {

        }

    public void SetToRope(Transform ropeTransform)
    {
        transform.parent = ropeTransform;
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;

       GetComponent<Rigidbody>().isKinematic = true;
    }

    public void Shot(float velocity)
    {
        transform.parent = null;
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().velocity = transform.forward * velocity;
    }

   
}
