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
    public Keyboard(float step, float run,GameObject camera_x, GameObject player)
    {
        this.step = step;
        this.run = run;
        this.camera_x = camera_x;  
        this.player = player;
    }

    public override void Camera_control()
    {
        move_camera = new Vector3(0, 0, 0);
        move_camera.x = Input.GetAxis("Mouse X");
        move_camera.y = Input.GetAxis("Mouse Y");
    }


  

    public override void Control(Weapone _mu_weapone, State _state)
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
          
            _state.is_menu = !_state.is_menu;
        }
       

        #region move
        //run
        if (Input.GetKey(KeyCode.LeftShift))
        {
         
            temp_step = run;
        }
        else
        {
            temp_step = step;
        }

        //right
        if (Input.GetKey(KeyCode.D))
        {
          
            _state.right = true;
        }
        else
        {
            _state.right = false;
        }
    
        //left
        if (Input.GetKey(KeyCode.A))
        {
         
            _state.left = true;
        }
        else
        {
            _state.left = false;
        }

        //forward
        if (Input.GetKey(KeyCode.W))
        {
          
            _state.forward = true;
        }
        else
        {
            _state.forward = false;
        }

        //beak
        if (Input.GetKey(KeyCode.S))
        {
         
            _state.back = true;
        }
        else
        {
            _state.back = false;
        }

        ////jump
        //if (Input.GetKeyDown(KeyCode.S))
        //{


        //}

        #endregion move

        #region Weapone
        //shot
        if (Input.GetMouseButton(0))
        {
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
        }

        //reload
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_mu_weapone != null)
            {
                _mu_weapone.Reload();
            }
        }
        

        #endregion Weapone
    }



    public override void Edit_Cord(State _state)
    {
        if (!_state.is_menu)
        {
            if (_state.back)
            {
                player.transform.Translate(-Vector3.forward * Time.deltaTime / temp_step);
            }
            else if (_state.forward)
            {
                player.transform.Translate(Vector3.forward * Time.deltaTime / temp_step);
            }
            if (_state.left)
            {
                player.transform.Translate(-Vector3.right * Time.deltaTime / temp_step);
            }
            if (_state.right)
            {
                player.transform.Translate(Vector3.right * Time.deltaTime / temp_step);
            }

            player.transform.Rotate(new Vector3(0, move_camera.x, 0));

            camera_x.transform.Rotate(new Vector3(-move_camera.y, 0, 0));
        }
    }
  

}
