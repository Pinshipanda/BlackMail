using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    public float InpuX = 0, InpuY = 0;
    public float VelMov = 1;
    public float turnSpeed = 1.0f;
    public Transform camara;

    Rigidbody rb;
    Vector3 direccion = Vector3.zero, direccionFinal = Vector3.zero;
    Quaternion targetRotation;
    Collider Col;

    public Animator ACon;
    int animState = 0;
    float speed = 0, walkSpeed, RunSpeed;
    bool isRunning = false, isalive = true;

    //Chest inclination
    Transform chest;
    [Range(-60,0)]
    public float chestWeight = 0;
    Vector3 Offsetchest;
    float animspeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Col = GetComponent<Collider>();
        walkSpeed = VelMov;
        RunSpeed = VelMov * 2.2f;
        if (rb == null)
        {
            Debug.LogError("No hay rigibody BOOOOOOOOOOI");
            enabled = false;
        }

        if (Col == null)
        {
            Debug.LogError("No hay Collider BOOOOOOOOOOI");
            enabled = false;
        }
        targetRotation = transform.rotation;
        chest = ACon.GetBoneTransform(HumanBodyBones.Chest);
        //ACon.recorderMode
    }

    void Update()
    {
        if (isalive)
        {
            InpuX = Input.GetAxis("Horizontal");
            InpuY = Input.GetAxis("Vertical");
            isRunning = Input.GetKey(KeyCode.LeftShift);
            direccion.x = InpuX;
            direccion.z = InpuY;

            MovementBehaviour();
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition((transform.position + (direccionFinal * VelMov) * Time.fixedDeltaTime));
    }

    void MovementBehaviour()
    {
        if (direccion.sqrMagnitude > 0.01f)
        {
            animspeed = chestWeight;
            animspeed = MathCH.Remap(animspeed, -60, 0, 0.8f, 1);
            //Debug.Log(animspeed);
            ACon.speed = animspeed;

            animState = 1;
            VelMov = walkSpeed;
            if (isRunning)
            {
                animState = 2;
                VelMov = RunSpeed;
            }

            ACon.SetInteger("MoveState", animState);

            direccionFinal = camara.TransformDirection(direccion);
            direccionFinal.Set(direccionFinal.x, 0, direccionFinal.z);

            if (direccionFinal.sqrMagnitude > 1.0f)
                direccionFinal.Normalize();
            VelMov *= animspeed;
            speed = direccionFinal.sqrMagnitude;
            //if (speed < 0.1f) speed = 0.1f;
            //ACon.SetFloat("Speed", speed);
            targetRotation = Quaternion.LookRotation(direccionFinal);
        }
        else
        {
            direccionFinal = Vector3.zero;
            animState = 0;
            ACon.SetInteger("MoveState", animState);
        }

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    }

    private void LateUpdate()
    {
        Offsetchest.x = chestWeight;
        chest.rotation *= Quaternion.Euler(Offsetchest);
    }

}
