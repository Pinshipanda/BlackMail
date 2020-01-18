using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class FP_PathingOBS : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    Transform waypoint;
    public NavMeshAgent agent;
    
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();

        if (agent == null)
        {
            Debug.LogError("The  nav mesh agent ! " + gameObject.name);
        }
        else
        {
            SetDestination();
        }
    }

    private void SetDestination()
    {
        if (waypoint != null)
        {
            Vector3 targetVector = waypoint.transform.position;
            agent.SetDestination(targetVector);
        }
    }
}
