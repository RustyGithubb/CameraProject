using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3DCamear : MonoBehaviour
{

    public GameObject AttaCameraPoint, FocusCameraPoint, Camera, pawn;
    public float _MovementLag, _RotationLag, Speed, rotationSpeed, runningSpeedFactor;
    bool CanFreeLook, isRunning;
    ControllerInput Controls;
    Animator _animator;

    public void OnEnable()
    {
        Controls.Enable();
    }

    private void OnDisable()
    {
        Controls.Disable();
    }

    private void Awake()
    {
        Controls = new ControllerInput();
        _animator = GetComponent<Animator>();
    }

    //=================================================================================

    private void FixedUpdate()
    {
        Vector2 movementValue = Controls._3DGame.Movement.ReadValue<Vector2>();

        if(movementValue != Vector2.zero)
        {

            _animator.SetFloat("Speed", isRunning ? 5 : 3);
            float _speed = Speed * (isRunning ? runningSpeedFactor : 1);
            transform.Translate(0, 0, _speed * movementValue.y * Time.deltaTime);
            transform.Rotate(0, rotationSpeed * movementValue.x * Time.deltaTime, 0);
        }
        else
        {
            _animator.SetFloat("Speed", 0);

        }


        //Camera.transform.position = Vector3.Lerp(transform.position, AttaCameraPoint.transform.position, _MovementLag * Time.deltaTime);
       // Camera.transform.rotation = Quaternion.Lerp(transform.rotation ,, _RotationLag * Time.deltaTime)


    }

}
