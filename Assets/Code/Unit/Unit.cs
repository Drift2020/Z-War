using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, IPunObservable
{
   
    public PhotonView photonView;
    public GameObject camera_X;
    public GameObject Arm;

    public AmmoUI my_ui;
    public My_input mu_input;
    public Weapone my_weapone;
    private State my_state;
    public SphereCollider Trigger;

    public string name;

    public float step;
    public float run;
    public float heat_point;

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(name);
            stream.SendNext(step);
            stream.SendNext(run);
            stream.SendNext(heat_point);

            //stream.SendNext(camera_X);
            //stream.SendNext(Arm);
            //stream.SendNext(my_ui);
            //stream.SendNext(mu_input);
            //stream.SendNext(my_weapone);
            //stream.SendNext(my_state);
            //stream.SendNext(Trigger);
           
          
        }
        if (stream.IsReading)
        {
            name = (string) stream.ReceiveNext();
            step = (float)stream.ReceiveNext();
            run = (float)stream.ReceiveNext();
            heat_point = (float)stream.ReceiveNext();

            //camera_X = (GameObject) stream.ReceiveNext();
            //Arm = (GameObject) stream.ReceiveNext();
            //my_ui = (AmmoUI) stream.ReceiveNext();
            //mu_input =  (My_input)stream.ReceiveNext();
            //my_weapone = (Weapone)stream.ReceiveNext();
            //my_state = (State) stream.ReceiveNext();
            //Trigger = (SphereCollider)stream.ReceiveNext();
        }
    }
  
    void Start()
    {
        photonView = GetComponent<PhotonView>();

        Screen.lockCursor = true;
        camera_X = transform.GetChild(1).gameObject;
        Trigger = transform.GetChild(0).GetComponent<SphereCollider>();
        mu_input = new Keyboard(step, run, camera_X, gameObject);
        my_state = new State();
        Arm = gameObject.transform.GetChild(1).transform.GetChild(0).gameObject;

     //   my_weapone = GetComponentInChildren<Gun>();
        
        if (my_weapone != null)
        {
            my_weapone.equip();
        }
  
    }


  
    void Update()
    {
        if(!photonView.IsMine) return;

        if (my_state.is_menu)
        {
            Screen.lockCursor = false;
        }
        else if (!my_state.is_menu)
        {
            Screen.lockCursor = true;
        }

        mu_input.Control(my_weapone, my_state);
        Take_item();
    }

    void FixedUpdate()
    {
       if(!photonView.IsMine) return;
       

       mu_input.Edit_Cord(my_state);     
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

}
