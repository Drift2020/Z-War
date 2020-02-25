﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public My_input mu_input;

    SphereCollider Trigger;

    public Weapone my_weapone;

    public string name;
    public float step;
    public float run;
    public float heat_point;
   
    public GameObject camera_X;
 


    // Start is called before the first frame update
    void Start()
    {
        Screen.lockCursor = true;
        my_weapone = GetComponentInChildren<Gun>();
        my_weapone.equip();
        mu_input = new Keyboard(step, camera_X,gameObject);
        Trigger = transform.GetChild(0).GetComponent<SphereCollider>();
        
    }


    // Update is called once per frame
    void Update()
    {

        mu_input.Edit_Cord();
        Take_item();
        



    }

    void FixedUpdate()
    {
        mu_input.Camera_control();
        mu_input.Control(my_weapone);
      
    }

    void Take_item()
    {
        foreach (Collider item in Physics.OverlapSphere(transform.position, 0.5f))
        {

            if (item.tag == "Ammo")
            {
                Ammo _ammo = item.GetComponent<Ammo>();

                if (_ammo.my_type == my_weapone.my_ammo)
                {
                    my_weapone.ammo += _ammo.count;
                    _ammo = null;
                    Destroy(item.gameObject);

                }
            }

        }
    }
   


}
