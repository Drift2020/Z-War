using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class My_input : MonoBehaviour
{

    public bool is_step;
    public bool is_run;

    protected float step;
    protected float temp_step;
    protected float run;

    public GameObject player;

    #region Camera
    public GameObject camera_x;

    public Vector3 move_camera;

    public float turnSmooth;
    public float pivotSpeed;
    public float Y_rot_speed;
    public float x_rot_speed;
    public float minAngle;
    public float maxAngle;
    public float normalZ;
    public float normalX;
    public float aimZ;
    public float aimX;
    public float normalY;

    #endregion Camera



    // Start is called before the first frame update


    public virtual void Control(Weapone _mu_weapone,State _state)
    {
     
    }

    public virtual void Camera_control()
    {

    }

    public virtual void Edit_Cord(State _state)
    {

    }
    // Update is called once per frame

}
