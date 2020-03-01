using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{

    public bool is_menu;

    public bool is_run;
    public bool is_step;
    public bool is_jump;
    public bool is_graund;

    public bool left;
    public bool right;
    public bool forward;
    public bool back;

    public State()
    {
        is_menu = false;
        is_run = false;
        is_step = true;
        is_jump = false;
        is_graund = true;

        left = false;
        right = false;
        forward = false;
        back = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

  
}
