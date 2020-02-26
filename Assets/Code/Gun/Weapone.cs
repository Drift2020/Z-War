using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ammo_type
{
    gun,
    bow,
    rocket
}

public interface Weapone 
{
    // Start is called before the first frame update


    bool is_shot { get; set; }
    bool is_trigger { get; set; }
    bool is_reload { get; set; }
    ammo_type my_ammo { get; }
    int ammo { get; set; }
    int max_clip { get; set; }
    int clip { get; set; }
    bool is_equip { get; set; }


    // Update is called once per frame


    void Shot();

    void Reload();

    void Trigger_is_pulled();

    void Trigger_is_not_pulled();

    void equip();
	
	void unequip();
    
}