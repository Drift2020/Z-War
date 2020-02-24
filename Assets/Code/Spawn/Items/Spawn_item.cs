using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_item : MonoBehaviour, Spawn
{
    #region variables
    [SerializeField]
    float _timeOut;

    [SerializeField]
    bool _is_created;

    [SerializeField]
    GameObject _obj;

    [SerializeField]
    My_timer _timer;

    [SerializeField]
    GameObject _item;

  
    public float timeOut {
        get
        {
            return _timeOut;
        }
        set
        {
            _timeOut = value;
        }
    }

    public bool is_created {
        get
        {
            return _is_created;
        }
        set
        {
            _is_created = value;
        }
    }

    public GameObject item {
        get
        {
            return _item;
        }
        set
        {
            _item = value;
        }
    }
    public GameObject obj {
        get
        {
            return _obj;
        }
        set
        {
            _obj = value;
        }
    }
    public My_timer timer {
        get
        {
            return _timer;
        }
        set
        {
            _timer = value;
        }
    }
    #endregion variables



    // Start is called before the first frame update

    public Spawn_item()
    {
        is_created = true;
        timer = new My_timer();
    }

    void Start()
    {

    }
   

    // Update is called once per frame
    void Update()
    {
        if(item==null && is_created)
        {
            is_created = false;
            timer.Start_timer(timeOut, Spawn_Item);
        }
        timer.Update();
    }


    public void Spawn_Item()
    {
        Debug.Log("Clone");
        item = Instantiate(obj, new Vector3(transform.position.x, transform.position.y+1, transform.position.z), Quaternion.identity);
        is_created = true;
    }
}
