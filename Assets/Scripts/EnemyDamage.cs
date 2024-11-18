using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour // Corrected here
{
    public PlayerHealth playerHealth;
    public int damage = 2;

    void Start()
    {
        // You might want to initialize playerHealth here or assign it in the inspector
    }

    void Update()
    {
        // Your logic for the enemy can go here (if needed)
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Using CompareTag for better performance
        {
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }
        }
    }
}
