using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    My_input mu_input;
    Weapone my_weapone;

    public string name;
    public float step;
    public float run;
    public float heat_point;



    // Start is called before the first frame update
    void Start()
    {
      
        mu_input = new Keyboard(step);
    }


    // Update is called once per frame
    void Update()
    {
        

        Edit_Cord();

    }

    void FixedUpdate()
    {
        mu_input.Move_control();
    }



    void Edit_Cord()
    {

        //if (mu_input.move.beak == 0001)
        //{
        //    gameObject.transform.Translate(-Vector3.forward * Time.deltaTime / step);
        //}
        //if (mu_input.move.forward == 0001)
        //{
        //    gameObject.transform.Translate(Vector3.forward * Time.deltaTime / step);
        //}
        //if (mu_input.move.left == 0001)
        //{
        //    gameObject.transform.Translate(-Vector3.right * Time.deltaTime / step);
        //}
        //if (mu_input.move.right == 0001)
        //{
        //    gameObject.transform.Translate(Vector3.right * Time.deltaTime / step);
        //}


        gameObject.transform.position = new Vector3(gameObject.transform.position.x +  (mu_input.move_step.x == 0 ? 0 : (Time.deltaTime / mu_input.move_step.x)),
                                                    gameObject.transform.position.y +  (mu_input.move_step.y == 0 ? 0 : (Time.deltaTime / mu_input.move_step.y)),
                                                    gameObject.transform.position.z +  (mu_input.move_step.z == 0 ? 0: (Time.deltaTime / mu_input.move_step.z)));
    }

}
