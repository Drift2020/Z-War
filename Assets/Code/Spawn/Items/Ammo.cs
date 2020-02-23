using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    ammo_type _my_type;
    int _count;

    public ammo_type my_type { get { return _my_type; }}

    public int count { get { return _count; } }


    public Ammo()
    {
        _my_type = 0;
        _count = 10;
    }

    public Ammo(int count, ammo_type my_type)
    {
        _my_type = my_type;
        _count = count;
    }
}
