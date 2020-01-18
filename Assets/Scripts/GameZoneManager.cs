using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameZoneManager : MonoBehaviour
{

    GameObject[] objs;

    public float distance= 2;

    // Start is called before the first frame update
    void Start()
    {
        objs = GameObject.FindGameObjectsWithTag("Obstaculos");
        //GetInactiveInRadius();
    }

    // Update is called once per frame
    void Update()
    {
        GetInactiveInRadius(distance);
    }

    public void GetInactiveInRadius(float _radius)
    {
        foreach (GameObject obj in objs)
        {
            if (Vector3.Distance(transform.position, obj.transform.position) < _radius)
                obj.SetActive(false);
        }
    }
}
