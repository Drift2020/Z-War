using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour, Weapone
{

    public bool  is_shot { get; set; }
    public bool is_trigger { get; set; }
    public bool is_reload { get; set; }
    public bool is_equip { get; set; }
    public int ammo { get; set; }
    public int clip { get; set; }
    public ammo_type _my_ammo { get; }

    public  Bow()
    {
        is_trigger = true;
        is_shot = false;
        is_reload= false;
        _my_ammo = 1;
        ammo = 10;
        clip = 1;
    }


   void Update()
	{
		if(!is_equip)
		{
			gameObject.transform.Rotate(0,1,0);
		}



	}


    public void Shot()
    {
        if (is_shot && clip>0 && is_trigger)
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
            
        }
    }

    public void Reload()
    {
        if(ammo>1)
        {
          
            if(clip > 0)
            {
                ammo = ammo - (1 - clip);
                clip = clip + (1 - clip);
            }
            else
            {
                ammo = ammo - 1;
                clip =  1 ;
            }
            
          
        }
        else if(ammo>0)
        {


            if (clip > 0)
            {
                ammo = ammo - (1 - clip);
                clip = clip + (1 - clip);
            }
            else
            {
               
                clip = ammo;
                ammo = 0;
            }

           
        }
    }


    public void Trigger_is_pulled()
    {
        is_trigger = false;
    }

    public void Trigger_is_not_pulled()
    {
        is_trigger = true;
    }


    public void equip()
	{
		is_equip =true;
	}
	
	public void unequip()
	{
		is_equip =false;
	}
}
