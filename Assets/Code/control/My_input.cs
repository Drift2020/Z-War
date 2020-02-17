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
    public GameObject _camera;
    public Move move;
    public Vector3 move_step;
    protected float step;

    // Start is called before the first frame update


    public virtual void Move_control()
    {

    }

    public virtual void Camera_control()
    {

    }

    // Update is called once per frame

}
