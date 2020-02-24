using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public delegate void SpawnItem();
public class My_timer 
{

    public float time;
    public bool is_end;
    bool is_pause;
    bool is_work;
    SpawnItem my_function;
    bool debug_level;




    public My_timer()
    {
        is_work = false;
        is_end = false;
        is_pause = false;
    }

    public void Update()
    {
        if (!is_pause && is_work && !is_end)
        {
            time = time - Time.deltaTime;
            Debug.Log("time:"+time);
        }
      
        if (time <= 0 && !is_end)
        {
            Debug.Log("END");
            my_function();
            is_end = true;
            is_work = false;
        }
    }

    public void Start_timer(float time, SpawnItem function)
    {
        Debug.Log("Start");
        this.time = time;
        is_pause = false;
        is_end = false;
        is_work = true;
        my_function = function;
    }

    public void Play_timer()
    {

        is_pause = false;
        is_end = false;
        is_work = true;
    }

    public void Pause_timer()
    {
        is_pause = true;
    }
}
