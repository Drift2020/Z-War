using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AmmoUI : MonoBehaviour
{
    public Unit my_weapone;
    public Text clip;
    public Text ammo;

    

    // Update is called once per frame
    void Update()
    {
        clip.text = my_weapone.my_weapone.clip.ToString();
        ammo.text = my_weapone.my_weapone.ammo.ToString();
    }
}
