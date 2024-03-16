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

    // Update is called once per frame
    void Update()
    {
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
}
