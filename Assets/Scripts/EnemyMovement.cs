using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    private Rigidbody2D rb;
    private Transform target;
    private Vector2 moveDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        // Find the player by name
        target = GameObject.Find("Player")?.transform;
    }

    void Update()
    {
        if (target)
        {
            // Calculate direction to the player
            Vector3 direction = (target.position - transform.position).normalized;
            moveDirection = direction;
        }
    }

    private void FixedUpdate()
    {
        if (target)
        {
            // Move the enemy towards the player
            rb.linearVelocity = moveDirection * moveSpeed;
        }
    }      
}
