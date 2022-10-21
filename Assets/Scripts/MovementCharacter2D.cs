using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementCharacter2D : MonoBehaviour
{

    ControllerInput Controller;
    Rigidbody rb;
    float MovementValue;
    public float _Speed;
    Animator _animator;
    public bool Negative, IsGrounded;
    public LayerMask ActorMask;
    private bool isRunning = false;


    private void Awake()
    {

        Controller = new ControllerInput();
        rb = GetComponent<Rigidbody>();   

    }

    private void OnEnable()
    {
        Controller.Enable();
    }

    public void OnDisable()
    {
        Controller.Disable();
    }

    private void FixedUpdate()
    {

        if (Physics.CheckSphere(transform.position, 0.5f, ActorMask))
        {
            IsGrounded = true;
        }
        else
        {
            IsGrounded = false;
            rb.velocity += new Vector3(0, -1, 0); // rajout de gravité pour le faire revenir plus vite au sol
        }

        Physics.CheckSphere(transform.position, 2);
        if (Controller._2DGame.Jump.IsPressed())
        {

            if(IsGrounded == true)
            {
                rb.AddForce(new Vector3(0, 15, 0), ForceMode.Impulse);
            }

        }
        
        MovementValue = Controller._2DGame.Movement.ReadValue<float>();
        if(MovementValue != 0)
        {
 
            if(MovementValue <= -0.1)
            {
                Negative = true;
                isRunning = true;
                transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));
                _animator.SetFloat("Speed", isRunning ? 5 : 3);
                transform.Translate(0, 0,  _Speed * Time.deltaTime);
            }
            if(MovementValue >= 0.1)
            {
                Negative = false;
                isRunning = true;
                transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
                _animator.SetFloat("Speed", isRunning ? 5 : 3);
                transform.Translate(0, 0,  _Speed * Time.deltaTime);
            }
        }
        else
        {
            isRunning = false;
            _animator.SetFloat("Speed", 0);
        }
    }

    void Start()
    {
        _animator = GetComponent<Animator>();
    }


    void Update()
    {
        
    }


}
