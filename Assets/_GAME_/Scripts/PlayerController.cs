using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float fastSpeed = 2f;
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
        moveSpeed = moveSpeed * fastSpeed;
    }

    private void ResetSpeed()
    {
        moveSpeed = currentMoveSpeed;
    }

}