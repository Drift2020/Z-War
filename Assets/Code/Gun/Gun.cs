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

    [SerializeField]
    int _max_clip;
    public int max_clip { get {return _max_clip; } set { _max_clip = value; } }

    ammo_type _my_ammo;
    public ammo_type my_ammo { get { return _my_ammo; } }


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
    void Start()
    {
        is_trigger = true;
        is_shot = false;
        is_reload = false;
        unequip();
        _my_ammo = ammo_type.gun;
        ammo = 25;
        clip = _max_clip;
    }

    public GameObject my_cross;
    public  Gun()
    {
        is_trigger = true;
        is_shot = false;
        is_reload= false;
        is_equip = false;
        _my_ammo = ammo_type.gun;
        ammo = 25;
        clip = _max_clip;

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
                    if (hit.transform.tag == "Kill")
                    {
                        hit.transform.gameObject.active = false;
                    }
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
        is_trigger = false;
    }

    public void Trigger_is_not_pulled()
    {
        is_trigger = true;
        is_shot = true;
    }


    public void equip()
	{
        tag = "Gun";
        transform.rotation = Quaternion.Euler(0, 0, 0);
        for (int i=0;i< transform.GetChildCount(); i++)
        {
            transform.GetChild(i).GetComponent<BoxCollider>().isTrigger = false;
        }
        is_equip =true;
	}
	
	public void unequip()
	{
        tag = "GunItem";
        for (int i = 0; i < transform.GetChildCount(); i++)
        {
            transform.GetChild(i).GetComponent<BoxCollider>().isTrigger = true;
        }
        is_equip =false;
	}
}



