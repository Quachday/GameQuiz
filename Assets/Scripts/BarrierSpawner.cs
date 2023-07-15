using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spr : MonoBehaviour
{
    public GameObject barrier;
   // public int NumOfQuiz = 3;
    public float spawnRate = 5;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(barrier, transform.position, transform.rotation);
    }
    

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Item")
        {
            if (timer < spawnRate)
            {
                timer = timer + Time.deltaTime;
            }
            else
            {
                Instantiate(barrier, transform.position, transform.rotation);
                timer = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && gameObject.tag == "Barrier" )        // continue the game
        {
            Instantiate(barrier, transform.position, transform.rotation);
        }
        
    }
}
