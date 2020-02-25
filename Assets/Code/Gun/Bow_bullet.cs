using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow_bullet : MonoBehaviour, Bullet
{
    public float hit { get; set; }
    public float radius { get; set; }
    public bool is_collision { get; set; }

    public Bow_bullet()
    {

    }
}
