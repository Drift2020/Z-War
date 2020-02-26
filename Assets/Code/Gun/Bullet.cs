using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Bullet
{
   float hit { get; set; }
   float radius { get; set; }
   bool is_collision { get; set; }
   float Speed { get; set; }
}
