using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour, Weapone
{

    public bool is_shot { get; set; }
    public bool is_trigger { get; set; }
    public bool is_reload { get; set; }
    public bool is_equip { get; set; }
    public int ammo { get; set; }
    public int clip { get; set; }
    public ammo_type _my_ammo { get; }


    public float _max_power_shot;
    public float _power_shot_step;
    float _power_shot;
    

    public  Bow()
    {
        is_trigger = true;
        is_shot = false;
        is_reload = false;
        is_equip = true;
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

        Shot();

	}


    public void Shot()
    {

        if(is_trigger&& _power_shot <= _max_power_shot)
        {
                _power_shot += Time.deltaTime * _power_shot_step / 100
        }

        if (clip>0 && !is_trigger)
        {
                    
           
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
        is_trigger = true;
    }

    public void Trigger_is_not_pulled()
    {
        is_trigger = false;
        
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
