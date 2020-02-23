using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public My_input mu_input;
    
    public Weapone my_weapone;

    public string name;
    public float step;
    public float run;
    public float heat_point;
   
    public GameObject camera_X;
 


    // Start is called before the first frame update
    void Start()
    {
        Screen.lockCursor = true;
        my_weapone = GetComponentInChildren<Gun>();
        mu_input = new Keyboard(step, camera_X,gameObject);
    }


    // Update is called once per frame
    void Update()
    {

        mu_input.Edit_Cord();



    }

    void FixedUpdate()
    {
        mu_input.Camera_control();
        mu_input.Control(ref my_weapone);
      
    }



 

}
