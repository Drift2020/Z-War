using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class Keyboard : My_input
{
    // Start is called before the first frame update
    void Start()
    {
        
    }




    public override void MoveControl()
    {
        Debug.Log(Input.GetKey(KeyCode.A)+" "+ Input.GetKey(KeyCode.D) + " " + Input.GetKey(KeyCode.W) + " " + Input.GetKey(KeyCode.S));
        //right
        if (Input.GetKey(KeyCode.D))
        {
            move.right = 0001;
        }
        else if(Input.GetKey(KeyCode.D) == false) 
        {
            move.right = 0000;
        }


        //left
        if (Input.GetKey(KeyCode.A))
        {

            move.left = 0001;
        }
        else if (Input.GetKey(KeyCode.A) == false)
        {
            move.left = 0000;
        }


        //forward
        if (Input.GetKey(KeyCode.W))
        {
            move.forward = 0001;
        }
        else if (Input.GetKey(KeyCode.W) == false)
        {
            move.forward = 0000;
        }


        //beak
        if (Input.GetKey(KeyCode.S))
        {

            move.beak = 0001;
        }
        else if (Input.GetKey(KeyCode.S)==false)
        {
            move.beak = 0000;
        }




        ////jump
        //if (Input.GetKeyDown(KeyCode.S))
        //{

        //    move.beak = 0001;
        //}
        //else if (Input.GetKeyUp(KeyCode.S))
        //{
        //    move.beak = 0000;
        //}


        ////run
        //if (Input.GetKeyDown(KeyCode.S))
        //{

        //    move.beak = 0001;
        //}
        //else if (Input.GetKeyUp(KeyCode.S))
        //{
        //    move.beak = 0000;
        //}


    }
    // Update is called once per frame
  
}
