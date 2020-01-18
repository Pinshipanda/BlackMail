using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FP_NPCpatrol : MonoBehaviour
{
    [SerializeField]
    bool _patrolWait;

    [SerializeField]
    float _totalwaitTime = 3f;

    [SerializeField]
    float _switchProb = 0.2f;

    [SerializeField]
    List<FP_Waypoint> _patrolPoints;

    NavMeshAgent agent;

    int _currentPatrolIndex;
    bool _travelling;
    bool _waiting;
    bool _patrolForward;
    float _waitTimer;

    public void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();

        if (agent == null)
        {
            Debug.LogError("The  nav mesh agent ! " + gameObject.name);
        }
        else
        {
            if (_patrolPoints != null && _patrolPoints.Count >= 2)
            {
                _currentPatrolIndex = 0;
                SetDestination();

            }
            else
            {
                Debug.Log("Puntos insuficientes para patrullar");
            }
        }
    }

    public void Update()
    {
        if (_travelling && agent.remainingDistance <=1.0f)
        {
            _travelling = false;

            if (_patrolWait)
            {
                _waiting = true;
                _waitTimer = 0f;

            }
            else
            {
                ChangePatrolPoint();
                SetDestination();
            }

            if (_waiting)
            {
                _waitTimer += Time.deltaTime;
                if (_waitTimer >= _totalwaitTime)
                {
                    _waiting = false;
                    ChangePatrolPoint();
                    SetDestination();
                }
            }
        }
    }
    private void SetDestination()
    {
        if (_patrolPoints != null)
        {
            Vector3 targetVector = _patrolPoints[_currentPatrolIndex].transform.position;
            agent.SetDestination(targetVector);
            _travelling = true;
        }
    }
    
    private void ChangePatrolPoint()
    {
        if (UnityEngine.Random.Range(0f,1f)<= _switchProb)
        {
            _patrolForward = !_patrolForward;

        }
        if (_patrolForward)
        {
            _currentPatrolIndex++;

            if (_currentPatrolIndex >= _patrolPoints.Count)
            {
                _currentPatrolIndex = 0;
            }
        }
        else
        {
            _currentPatrolIndex--;
            if (_currentPatrolIndex<0)
            {
                _currentPatrolIndex = _patrolPoints.Count - 1;
            }
            /*if (--_currentPatrolIndex < 0)
            {
                _currentPatrolIndex = _patrolPoints.Count - 1;
            }*/
        }
    }

}
