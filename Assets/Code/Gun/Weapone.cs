using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ammo_type
{
    gun

}

public interface Weapone 
{
    // Start is called before the first frame update


    bool is_shot { get; set; }
    bool re_shot { get; set; }
    ammo_type _my_ammo { get; }
    int ammo { get; set; }
    int clip { get; set; }
    bool is_equip { get; set; }


    // Update is called once per frame


    void Shot();

    void Reload();

    void equip();
	
	void unequip();
    
}