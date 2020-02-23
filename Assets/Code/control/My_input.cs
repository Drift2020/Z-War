using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public struct Move
{
    public uint forward;
    public uint beak;
    public uint left;
    public uint right;
}
public abstract class My_input : MonoBehaviour
{

    public Move move;
    public Vector3 move_step;
    protected float step;

    public GameObject player;

    #region Camera
    public GameObject camera_y;
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


    public virtual void Control(ref Weapone my_weapone)
    {
     
    }

    public virtual void Camera_control()
    {

    }

    public virtual void Edit_Cord()
    {

    }
    // Update is called once per frame

}
