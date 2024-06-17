using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float playerStamina = 2f;
    [SerializeField] float moveSpeed = 1f;
    [SerializeField]float fastSpeed = 2f;
    private float currentMoveSpeed;

    private PlayerControls playerControls;
    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;


    private void Awake()
    {
        currentMoveSpeed = moveSpeed;
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();


    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void Update()
    {
        PlayerInput();

    }

    private void FixedUpdate()
    {
        playerControls.Movement.Run.started += ctx => SpeedUp();
        playerControls.Movement.Run.canceled += ctx => ResetSpeed();
        Move();
    }

    private void PlayerInput()
    {
        movement = playerControls.Movement.Move.ReadValue<Vector2>();

        if (movement.magnitude == 0)
        {
            animator.SetBool("isWalking", false);
        }
        else
        {
            animator.SetBool("isWalking", true);
            animator.SetFloat("moveY", movement.y);
            animator.SetFloat("moveX", movement.x);
        }

    }

    private void Move()
    {
        rb.MovePosition(rb.position + movement * (moveSpeed * Time.fixedDeltaTime));
    }

    private void SpeedUp()
    {
        if(playerStamina > 0)
        {
        moveSpeed = moveSpeed * fastSpeed;
        playerStamina -= Time.deltaTime * 1.5f;
        }
        else
        {
        playerStamina += Time.deltaTime * 0.4f;
        moveSpeed = currentMoveSpeed;
        }

        if(playerStamina > 2f) 
        playerStamina = 2f;

    }

    private void ResetSpeed()
    {
        moveSpeed = currentMoveSpeed;
    }

}