using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierMoveScript : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Character" && gameObject.tag == "Barrier")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Do something here");
            Time.timeScale = 0.0f; // Quiz appear pause the animation
        }
        else if (collision.gameObject.tag == "Character" && gameObject.tag == "Item")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Destroy(gameObject);
        }
    }
    void DestroyBarrier()
    { 
            Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime;
        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.Space) && gameObject.tag == "Barrier")        // continue the game
        {   
            speed = 0;
            Time.timeScale = 1.0f;
            //  animator.SetBool("isCorrect", true);
            // if (transform.position.x < 0)
            //  {
            //     transform.position = transform.position + (Vector3.right) / 2;
            //  }
            //animator.speed += (float)upspeed;
            //bGScroller.IncrementSpeed();
            Invoke("DestroyBarrier",0.5f);
        }
       // else
       // {
          //  animator.SetBool("isCorrect", false);
      //  }
    }
}
