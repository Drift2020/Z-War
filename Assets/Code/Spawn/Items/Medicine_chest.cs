using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medicine_chest : MonoBehaviour
{
    int _count;

    public int count { get { return _count; } }
   
    public Medicine_chest()
    {     
        _count = 50;
    }

    public Medicine_chest(int count)
    {
        _count = count;
    }

    void Update()
    {
        gameObject.transform.Rotate(0, 1, 0);  
    }
}
