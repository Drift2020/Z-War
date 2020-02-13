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
    // Start is called before the first frame update

  
    public virtual void MoveControl()
    {

    }

    // Update is called once per frame
 
}
