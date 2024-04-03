using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Vector2 move;

    public Animator animator;

    public bool stopRight;
    public bool stopLeft;
    public bool stopUp;
    public bool stopDown;

    private void FixedUpdate()
    {
        stopRight = Physics.Raycast(transform.position, Vector3.right, 0.67f);
        stopLeft = Physics.Raycast(transform.position, Vector3.left, 0.67f);
        stopUp = Physics.Raycast(transform.position, Vector3.up, 0.67f);
        stopDown = Physics.Raycast(transform.position, Vector3.down, 0.67f);
    }

    // Update is called once per frame
    void Update()
    {
        //if (!stopRight)
        //{
        //    moveRight(move);
        //}

        //if (!stopLeft)
        //{
        //    moveLeft(move);
        //}

        //if (!stopUp)
        //{
        //    moveUp(move);
        //}

        //if (!stopDown)
        //{
        //    moveDown(move);
        //}

        //if (!stopRight || !stopLeft || !stopUp || !stopDown)
        //{
        //    movePlayer();
        //}

        movePlayer();

        animator.SetFloat("move.x", move.x);
        animator.SetFloat("move.y", move.y);
        animator.SetFloat("speed", speed);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    private void movePlayer()
    {
        Vector3 movement = new Vector3(move.x, 0f, move.y);

        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

    private void moveRight(Vector2 movement)
    {
        if (movement.x > 0)
        {
            movement = new Vector3(move.x, 0f, move.y);

            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);

            transform.Translate(movement * speed * Time.deltaTime, Space.World);
        }
    }

    private void moveLeft(Vector2 movement)
    {
        if (movement.x < 0)
        {
            movement = new Vector3(move.x, 0f, move.y);

            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);

            transform.Translate(movement * speed * Time.deltaTime, Space.World);
        }
    }

    private void moveUp(Vector2 movement)
    {
        if (movement.y > 0)
        {
            movement = new Vector3(move.x, 0f, move.y);

            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);

            transform.Translate(movement * speed * Time.deltaTime, Space.World);
        }
    }

    private void moveDown(Vector2 movement)
    {
        if (movement.y < 0)
        {
            movement = new Vector3(move.x, 0f, move.y);

            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);

            transform.Translate(movement * speed * Time.deltaTime, Space.World);
        }
    }
}
