using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    float inputHorizontal;
    float inputVertical;

    float speed = 40f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        if (inputHorizontal != 0)
        {
            rb.AddForce(new Vector2(inputHorizontal * speed, 0f));
            GetComponent<Animator>().SetBool("isWalking", true);
        }

        else
        {
            rb.AddForce(new Vector2(inputHorizontal * speed, 0f));
            GetComponent<Animator>().SetBool("isWalking", false);
        }
        //Flips Right
        if (inputHorizontal > 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        //Flips Left
        if (inputHorizontal < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}

