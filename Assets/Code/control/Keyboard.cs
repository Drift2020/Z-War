using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class Keyboard : My_input
{
    // Start is called before the first frame update

    public Keyboard(float step)
    {
        this.step = step;
    }


    public override void Camera_control()
    {

    }


  

    public override void Move_control()
    {
        
        move_step = new Vector3(0,0,0);
       
        //right
        if (Input.GetKey(KeyCode.D))
        {
            move_step.x = step;
           // move.right = 0001;
        }
        //else if(Input.GetKey(KeyCode.D) == false) 
        //{
           
        //    move.right = 0000;
        //}


        //left
        if (Input.GetKey(KeyCode.A))
        {
            move_step.x = -step;
         //   move.left = 0001;
        }
        //else if (Input.GetKey(KeyCode.A) == false)
        //{
        //    move.left = 0000;
        //}


        //forward
        if (Input.GetKey(KeyCode.W))
        {
            move_step.z = step;
            //move.forward = 0001;
        }
        //else if (Input.GetKey(KeyCode.W) == false)
        //{
        //    move.forward = 0000;
        //}


        //beak
        if (Input.GetKey(KeyCode.S))
        {
            move_step.z = -step ;
          //  move.beak = 0001;
        }
        //else if (Input.GetKey(KeyCode.S)==false)
        //{
        //    move.beak = 0000;
        //}




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
