using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beverflee : MonoBehaviour
{
 

    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float disToPlayer = Vector2.Distance(transform.position, player.position);
        if (disToPlayer < agroRange)
        {
            ChasePlayer();
        }
        else
        {
            StopChasingPlayer();
        }
    }
  
    private void ChasePlayer()
    {
        if (transform.position.x > player.position.x)
        {
            rb.velocity = new Vector2(moveSpeed, 0);

        }
        else
        {
            rb.velocity = new Vector2(-moveSpeed, 0);
            //transform.localScale = new Vector2(-1, 1);

        }
    }

    private void StopChasingPlayer()
    {
        rb.velocity = new Vector2(0, 0);
    }
}

