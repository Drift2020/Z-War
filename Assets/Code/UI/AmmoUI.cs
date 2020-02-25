using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AmmoUI : MonoBehaviour
{
    public Unit player;
    public Text clip;
    public Text ammo;

    

    // Update is called once per frame
    void Update()
    {
       
        if (player.my_weapone != null)
        {
            clip.text = player.my_weapone.clip.ToString();
            ammo.text = player.my_weapone.ammo.ToString();
        }
    }
}
