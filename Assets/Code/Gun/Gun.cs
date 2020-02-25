using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour, Weapone
{

    public bool  is_shot { get; set; }
    public bool is_trigger { get; set; }
    public bool is_reload { get; set; }
    public bool is_equip { get; set; }
    public int ammo { get; set; }
    public int clip { get; set; }

    int max_clip;
    public int max_clip { get; set; }

    public ammo_type _my_ammo { get; }


    void Update()
	{
		if(!is_equip)
		{
			gameObject.transform.Rotate(0,1,0);
		}

        Shot();

        
        if(clip != max_clip && is_reload)
        {
            Reload();
        }

	}

    public GameObject my_cross;
    public  Gun()
    {
        is_trigger = true;
        is_shot = false;
        is_reload= false;
        is_equip = true;
        _my_ammo = 0;
        ammo = 25;
        clip = max_clip;
    }

    public void Shot()
    {
        if (is_shot && clip>0 && !is_trigger)
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
            is_shot = false;
        }
    }

    public void Reload()
    {

        if(ammo>max_clip)
        {
          
            if(clip > 0)
            {
                ammo = ammo - (max_clip - clip);
                clip = clip + (max_clip - clip);
            }
            else
            {
                ammo = ammo - max_clip;
                clip =  max_clip ;
            }
            
          
        }
        else if(ammo>0)
        {


            if (clip > 0)
            {
                ammo = ammo - (max_clip - clip);
                clip = clip + (max_clip - clip);
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
        is_trigger = true;
    }

    public void Trigger_is_not_pulled()
    {
        is_trigger = false;
        is_shot = true;
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



