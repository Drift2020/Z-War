using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, IPunObservable
{
    private SphereCollider Trigger;
    private PhotonView photonView;
    private AmmoUI my_ui;
    private GameObject camera_X;
    private GameObject Arm;

    private string name;
    private float step;
    private float run;
    private float heat_point;


    public My_input mu_input;
    public Weapone my_weapone;




    


    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();
        camera_X = transform.GetChild(1).gameObject;
        Trigger = transform.GetChild(0).GetComponent<SphereCollider>();
        mu_input = new Keyboard(step, camera_X, gameObject);
        Arm = gameObject.transform.GetChild(1).transform.GetChild(0).gameObject;

        Screen.lockCursor = true;

        my_weapone = GetComponentInChildren<Gun>();
        
        if (my_weapone != null)
        {
            my_weapone.equip();
        }
   
        
        


    }


    // Update is called once per frame
    void Update()
    {
        if(!photonView.IsMine) return;


        mu_input.Control(my_weapone);
        Take_item();
        



    }

    void FixedUpdate()
    {
        if(!photonView.IsMine) return;
       

        mu_input.Edit_Cord();
        mu_input.Camera_control();
      
      
    }

    void Take_item()
    {
        foreach (Collider item in Physics.OverlapSphere(transform.position, 0.5f))
        {
           
            if (item.tag == "Ammo")
            {
                Ammo _ammo = item.GetComponent<Ammo>();

                if (my_weapone != null && _ammo.my_type == my_weapone.my_ammo)
                {
                    my_weapone.ammo += _ammo.count;
                    _ammo = null;
                    Destroy(item.gameObject);

                }
            }

            else if (item.tag == "Medicine_chest")
            {
                Medicine_chest _medicine_chest = item.GetComponent<Medicine_chest>();

                if (heat_point<100)
                {

                    heat_point += _medicine_chest.count;

                    if(heat_point>100)
                    {
                        heat_point=100;
                    }

                    Destroy(item.gameObject);

                }
            }

            else if (item.tag == "GunItem")
            {
                my_weapone = item.GetComponent<Gun>();
                my_weapone.equip();
                item.transform.SetParent(Arm.transform);
               
                item.transform.position = new Vector3(Arm.transform.position.x , Arm.transform.position.y, Arm.transform.position.z);
                item.transform.localRotation = new Quaternion(0, 0, 0, 0);
            }

        }
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        throw new NotImplementedException();
    }
}
