using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public float VelRotacion = 1;
    public float VelDisplacement = 1.0f;
    public Vector3 DesiredPos;
    public Transform Objective;
    //float mouseX, mouseY;
    private Vector3 velocity = Vector3.zero;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        //Time.timeScale = 0.1f;
    }
   /* private void Update()
    { 

    }

    private void LateUpdate()
    {
        CamControl(); Deberia verse smooth pero ni idea
    }*/
    private void FixedUpdate()
    {
        //Objetivo.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        CamControl();
    }

    void CamControl()
    {
        //Para que vaya ala posicionDeseada despacito
        Vector3 PosicionSuave = Vector3.SmoothDamp(transform.position, Objective.position+DesiredPos, ref velocity, VelDisplacement);
        //no se porque necesita una ref la funcion pero con vector3.zero jala asi que arre

        transform.position = PosicionSuave;
        //transform.rotation = Quaternion.Slerp(transform.rotation, Objetivo.rotation, 10 * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(Objective.position + DesiredPos, 1.0f);
    }
}
