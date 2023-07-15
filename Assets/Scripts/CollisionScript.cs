using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int speed = 5;
    public Animator animator;
    Rigidbody2D rb;
   // spr barrierSpawner;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        //barrierSpawner = GameObject.FindGameObjectWithTag("Barrier").GetComponent<spr>();
        rb = GetComponent<Rigidbody2D>();
    }
   
    void Update() {
        MovePlayer();
    }


    void MovePlayer()
    {
        /*if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + (Vector3.right * speed) * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = transform.position + (Vector3.up * 20) * Time.deltaTime;
            animator.SetTrigger("Jump");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + (Vector3.down * speed) * Time.deltaTime;
        }
        */
        if (Input.GetKeyDown(KeyCode.Space))        // continue the game
        {
            animator.SetTrigger("Attack");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("Jump");
            rb.velocity = new Vector2(rb.velocity.x, 10f);
        }
    }
}
