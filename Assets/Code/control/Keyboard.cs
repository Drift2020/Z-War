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
    public Keyboard(float step,GameObject camera_x, GameObject player)
    {
        this.step = step;
        this.camera_x = camera_x;
     
        this.player = player;
    }

    public override void Camera_control()
    {
        move_camera = new Vector3(0, 0, 0);

        move_camera.x = Input.GetAxis("Mouse X");
        move_camera.y = Input.GetAxis("Mouse Y");

        

    }


  

    public override void Control(Weapone _mu_weapone)
    {
        
        move_step = new Vector3(0,0,0);
       
        //right
        if (Input.GetKey(KeyCode.D))
        {
            move_step.x = step;
           
        }
    
        //left
        if (Input.GetKey(KeyCode.A))
        {
            move_step.x += -step;
       
        }
       
        //forward
        if (Input.GetKey(KeyCode.W))
        {
            move_step.z = step;
         
        }

        //beak
        if (Input.GetKey(KeyCode.S))
        {
            move_step.z += -step ;
        
        }

        //shot
        if (Input.GetMouseButton(0))
        {

            //  my_weapone.is_shot = true;
            //  my_weapone.Trigger_is_pulled();
            //   my_weapone.re_shot = false;
            if (_mu_weapone != null)
            {
                _mu_weapone.Trigger_is_pulled();
            }
        }
        else
        {
            if (_mu_weapone != null)
            {
                _mu_weapone.Trigger_is_not_pulled();
            }
         //   my_weapone.is_shot = false;
          //  my_weapone.re_shot = true;
        }


        //reload
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_mu_weapone != null)
            {
                _mu_weapone.Reload();
            }
          

        }
        //else
        //{
        //    _mu_weapone.is_reload = false;
        //}

        ////jump
        //if (Input.GetKeyDown(KeyCode.S))
        //{


        //}


        ////run
        //if (Input.GetKeyDown(KeyCode.S))
        //{


        //}


    }



  public override void Edit_Cord()
    {

        if (move_step.z < 0)
        {
            player.transform.Translate(-Vector3.forward * Time.deltaTime / step);
        }
        if (move_step.z > 0)
        {
            player.transform.Translate(Vector3.forward * Time.deltaTime / step);
        }
        if (move_step.x < 0)
        {
            player.transform.Translate(-Vector3.right * Time.deltaTime / step);
        }
        if (move_step.x > 0)
        {
            player.transform.Translate(Vector3.right * Time.deltaTime / step);
        }





      
        player.transform.Rotate(new Vector3(0, move_camera.x, 0));

        camera_x.transform.Rotate(new Vector3(-move_camera.y, 0, 0));


       
    }
    // Update is called once per frame

}
