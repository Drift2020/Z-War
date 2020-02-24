using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Spawn
{
    
    float timeOut { get; set; }
    bool is_created { get; set; }
    GameObject item { get; set; }
    GameObject obj { get; set; }

    My_timer timer { get; set; }

    void Spawn_Item();
    

}
