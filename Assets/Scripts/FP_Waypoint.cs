using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FP_Waypoint : MonoBehaviour
{
    [SerializeField]
    protected float debugRadio = 1.0f;

   public virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, debugRadio);
    }
}
