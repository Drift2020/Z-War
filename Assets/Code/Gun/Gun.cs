using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour, Weapone
{

    public bool  is_shot { get; set; }

    public int ammo { get; set; }
    public int clip { get; set; }

    public bool re_shot { get; set; }





    public GameObject my_cross;
    public  Gun()
    {
        re_shot = true;
        is_shot = false;

        ammo = 25;
        clip = 6;
    }

    public void Shot()
    {
        if (is_shot && clip>0 && re_shot)
        {
                    
            RaycastHit hit;
            // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Ray ray = new Ray(my_cross.transform.position, Vector3.forward);
            if (Physics.Raycast(my_cross.transform.position, transform.TransformDirection(Vector3.forward),out hit))
            {
                if (hit.collider != null)
                {
                   hit.transform.gameObject.active = false;
                   Debug.DrawLine(my_cross.transform.position, transform.TransformDirection(Vector3.forward));               
                }
            }
            clip--;
            re_shot = false;
        }
    }

    public void Reload()
    {
        if(ammo>6)
        {
          
            if(clip > 0)
            {
                ammo = ammo - (6 - clip);
                clip = clip + (6 - clip);
            }
            else
            {
                ammo = ammo - 6;
                clip =  6 ;
            }
            
          
        }
        else if(ammo>0)
        {


            if (clip > 0)
            {
                ammo = ammo - (6 - clip);
                clip = clip + (6 - clip);
            }
            else
            {
               
                clip = ammo;
                ammo = 0;
            }

           
        }
    }
}



